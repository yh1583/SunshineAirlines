using SunshineAirlines1.Dals;
using SunshineAirlines1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunshineAirlines1.Forms.OfficeUser
{
    public partial class FoodServices : Form
    {
        public FoodServices()
        {
            InitializeComponent();
        }

        private class food
        {
            public food(bool isChecked, int nums)
            {
                IsChecked = isChecked;
                Nums = nums;
            }
            public bool IsChecked { get; set; }

            public int Nums { get; set; }
        }

        

     

        private int selectedItems = 0;

        private int selectedAmount = 0;

        private float payment = 0;

        private List<FlightFood> flightFoodsList = new List<FlightFood>();

        private List<food> foodList = new List<food>();

        private List<food> foodListByModifyMode = null;


        private void btn_search_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> flightDic = new Dictionary<int, string>();
            if (txt_idTypeNum.Text!="")
            {
                List<FlightReservation> list = FlightReservationDal.FindById(txt_idTypeNum.Text);
                for (int i = 0; i < list.Count; i++)
                {
                    flightDic.Add(list[i].ReservationId,(list[i].Schedule.FlightNumber+","+list[i].Schedule.Route.DepartureAirportIATA+"-"+list[i].Schedule.Route.ArrivalAirportIATA+","+list[i].Schedule.Date.ToString("yyyy-MM-dd")+","+list[i].Schedule.Time+","+list[i].CabinType.CabinTypeName));
                }
                cbx_flight.DataSource = new BindingSource(flightDic,null);
                cbx_flight.DisplayMember = "value";
                cbx_flight.ValueMember = "key";
            }
            else
            {
                MessageBox.Show("请输入ID");
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {

                if (FlightFoodReservationDal.IsAlreadyExist((int)cbx_flight.SelectedValue))
                {


                    List<FlightFoodReservation> ffrList = new List<FlightFoodReservation>();
                    for (int i = 0; i < foodList.Count; i++)
                    {
                        if (foodList[i].IsChecked)
                        {
                            ffrList.Add(new FlightFoodReservation
                            {
                                ReservationId = (int)cbx_flight.SelectedValue,
                                FoodId = i + 1,
                                Amount = foodList[i].Nums
                            });

                        }

                    }
                    if (ffrList.Count == 0)
                    {
                        FlightFoodReservationDal.ClearFood((int)cbx_flight.SelectedValue);
                    }
                    else
                    {
                        FlightFoodReservationDal.ModifyFood(ffrList);
                    }
                    MessageBox.Show("修改成功");
                    btn_load_Click(sender, e);
                }
                else
                {
                    for (int i = 0; i < foodList.Count; i++)
                    {
                        if (foodList[i].IsChecked)
                        {
                            FlightFoodReservationDal.ConifrmFoodReservation(new FlightFoodReservation
                            {
                                ReservationId = (int)cbx_flight.SelectedValue,
                                FoodId=i+1,
                                Amount=foodList[i].Nums
                            }) ;
                        }
                    }
                    MessageBox.Show("订餐成功");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("订餐/修改失败");
                return;
            }
        }


        private void btn_load_Click(object sender, EventArgs e)
        {
            if (cbx_flight.SelectedValue!=null)
            {
                if (!IsLessThanSixHours(cbx_flight.SelectedValue.ToString()))
                {
                    if (FlightFoodReservationDal.IsAlreadyExist((int)cbx_flight.SelectedValue))
                    {
                        InitFoodList();
                        ClearFoodList();
                        QueryToFill((int)cbx_flight.SelectedValue);

                    }
                    else
                    {
                        InitFoodList();
                        ClearFoodList();
                        foodListByModifyMode = null;
                    }

                }
                else
                {
                    pan_food.Controls.Clear();
                    MessageBox.Show("必须在飞机起飞 6 小时（包含）之前购买/修改");
                }
               
            }
        }

        private void QueryToFill(int value)
        {
            List<FlightFoodReservation> flightFoodReservationsList = FlightFoodReservationDal.GetListByID(value);
            if (flightFoodReservationsList.Count!=0)
            {
                foodListByModifyMode = new List<food>();
                foodListByModifyMode.Clear();
                for (int i = 0; i < 18; i++)
                {
                    foodListByModifyMode.Add(new food(false,1));
                }
                foreach (var ffr in flightFoodReservationsList)
                {
                    foodListByModifyMode[ffr.FoodId - 1].IsChecked = true;
                    foodListByModifyMode[ffr.FoodId - 1].Nums = ffr.Amount;
                    foreach (Control foodUnit in pan_food.Controls)
                    {
                        if (foodUnit.Name.Split('_')[1]==ffr.FoodId.ToString())
                        {
                            CheckBox checkBox = foodUnit.Controls["che_isSelected"] as CheckBox;
                            NumericUpDown num = foodUnit.Controls["nud_foodNumber"] as NumericUpDown;
                            checkBox.Checked = true;
                            num.Value = ffr.Amount;
                        }
                    }
                }
            }
            else
            {

            }
        }

        private void ClearFoodList()
        {
            foodList.Clear();
            for (int i = 0; i < 18; i++)
            {
                foodList.Add(new food(false,1));
            }
            lbl_payment.Text = "$ " + 0.ToString("F2");
            lbl_selectAmount.Text = 0.ToString();
            lbl_selectItem.Text = 0.ToString();
        }

        private void InitFoodList()
        {
            pan_food.Controls.Clear();
            flightFoodsList = FlightFoodDal.GetList();
            int nowX = 10;
            int nowY = 10;
            for (int i = 0; i < 18; i++)
            {
                FoodUnit foodUnit = new FoodUnit(flightFoodsList[i]);
                foodUnit.Name = "food_" + flightFoodsList[i].FoodId;
                CheckBox che = foodUnit.Controls["che_isSelected"] as CheckBox;
                che.CheckedChanged += new EventHandler(CheckBoxCheckedChange);
                NumericUpDown num = foodUnit.Controls["nud_foodNumber"] as NumericUpDown;
                num.ValueChanged += new EventHandler(NumericUpDownChange);
                foodUnit.Location = new Point(nowX,nowY);
                nowX += foodUnit.Width + 10;
                pan_food.Controls.Add(foodUnit);
                if (((i+1)%4)==0)
                {
                    nowY += foodUnit.Height + 10;
                    nowX = 10;
                }
            }
        }

        private void NumericUpDownChange(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            FoodUnit foodUnit = num.Parent as FoodUnit;
            string controlID = foodUnit.Name.Split('_')[1];
            CheckBox checkBox = foodUnit.Controls["che_isSelected"] as CheckBox;
            if (num.Value<=0)
            {
                MessageBox.Show("请输入正确的数字");
                num.Value = foodList[int.Parse(controlID)].Nums;
            }
            else
            {
                foodList[int.Parse(controlID) - 1] = new food(checkBox.Checked,(int)num.Value);
                CalculationFood();
            }
        }

        private void CheckBoxCheckedChange(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            FoodUnit foodUnit = checkBox.Parent as FoodUnit;
            string controlID = foodUnit.Name.Split('_')[1];
            NumericUpDown num = foodUnit.Controls["nud_foodNumber"] as NumericUpDown;
            foodList[int.Parse(controlID) - 1] = new food(checkBox.Checked, (int)num.Value);
            CalculationFood();
        }

       

        private bool IsLessThanSixHours(string selectedValue)
        {
            DateTime dateTime = FlightReservationDal.QueryDateTimeByRID(selectedValue);
            if (dateTime==DateTime.MinValue)
            {
                return false;
            }
            dateTime = dateTime.AddHours(dateTime.Hour-6);
            if (DateTime.Compare(DateTime.Now,dateTime)>=0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CalculationFood()
        {
            if (foodListByModifyMode==null)
            {
                selectedAmount = 0;
                selectedItems = 0;
                payment = 0;
                for (int i = 0; i < foodList.Count; i++)
                {
                    if (foodList[i].IsChecked)
                    {
                        selectedItems++;
                        selectedAmount += foodList[i].Nums;
                        payment += ((float)(flightFoodsList[i].Price)) * foodList[i].Nums;
                    }
                }
                lbl_paymentState.Text = "Payment: $";
                lbl_payment.Text = payment.ToString("F2");
                lbl_selectAmount.Text = selectedAmount.ToString();
                lbl_selectItem.Text = selectedItems.ToString();
            }
            else
            {

                selectedAmount = 0;
                selectedItems = 0;
                payment = 0;
                int lastSA = 0;
                int lastSI = 0;
                float lastPayment = 0;
                float nowPayment = 0;
                for (int i = 0; i < foodList.Count; i++)
                {
                    if (foodListByModifyMode[i].IsChecked)
                    {
                        lastSI++;
                        lastSA += foodListByModifyMode[i].Nums;
                        lastPayment += (float)(flightFoodsList[i].Price)*(foodListByModifyMode[i].Nums);
                    }
                }
                for (int i = 0; i < foodList.Count; i++)
                {
                    if (foodList[i].IsChecked)
                    {
                        selectedItems++;
                        selectedAmount += foodList[i].Nums;
                        payment += ((float)(flightFoodsList[i].Price)) * foodList[i].Nums;
                    }
                }
                nowPayment = payment - lastPayment;
                if (nowPayment<0)
                {
                    lbl_paymentState.Text = "Refund: $";
                    nowPayment = -nowPayment;
                }
                else
                {
                    lbl_paymentState.Text = "Payment: $";
                }
                lbl_payment.Text = payment.ToString("F2");
                lbl_selectAmount.Text = selectedAmount.ToString();
                lbl_selectItem.Text = selectedItems.ToString();
            }
        }

        private void FoodServices_Load(object sender, EventArgs e)
        {
            cbx_idType.SelectedIndex = 0;
            ClearFoodList();

            AllFun.CheckAllCtrls(this);
            AllFun.ReplaceByLanguageMode();
        }
    }
}
