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

namespace SunshineAirlines1.Forms.Administrator
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }


        private DataTable userDt;

        private int sumPage = 0;

        private int nowPage = 1;

        private List<User> userList;

        private void btn_first_Click(object sender, EventArgs e)
        {
            nowPage = 1;
            ClearTable();
            cbx_pageNum.SelectedIndex = nowPage - 1;
            dgv_resultList.DataSource = GetNewDataTable().DefaultView;
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            if (nowPage==1)
            {
                return;
            }
            else
            {
                nowPage -=1;
                cbx_pageNum.SelectedIndex = nowPage - 1;
                ClearTable();
                dgv_resultList.DataSource = GetNewDataTable().DefaultView;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (nowPage==sumPage)
            {
                return;
            }
            else
            {
                nowPage += 1;
                cbx_pageNum.SelectedIndex = nowPage - 1;
                ClearTable();
                dgv_resultList.DataSource = GetNewDataTable().DefaultView;

            }
           
        }

        private void btn_end_Click(object sender, EventArgs e)
        {

            nowPage = sumPage;
            cbx_pageNum.SelectedIndex = nowPage - 1;
            ClearTable();
            dgv_resultList.DataSource = GetNewDataTable().DefaultView;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            InitDataTable();
            userList = UsersDal.GetUserList(txt_name.Text,cbx_role.SelectedIndex);
            foreach (var user in userList)
            {
                DataRow row = userDt.NewRow();
                row["Email"] = user.Email;
                row["Name"]=user.FirstName+" "+user.LastName;
                row["Gender"] = user.Gender == "M" ? "Male" : "Female";
                row["DateOfBirth"] = user.DateOfBirth.ToString("yyyy-MM-dd");
                row["Phone"] = user.Phone;
                row["Role"] = user.RoleId == 1 ? "Office User" : "Administrator";
                userDt.Rows.Add(row);
            }
            btn_last.Enabled = true;
            btn_next.Enabled = true;
            btn_end.Enabled = true;
            btn_first.Enabled = true;
            cbx_pageNum.Enabled = true;

            sumPage =(userDt.Rows.Count % 20) != 0 ? ((userDt.Rows.Count / 20) + 1) : (userDt.Rows.Count / 20);
            nowPage = 1;
            lbl_totalPages.Text = sumPage.ToString();
            lbl_totalRecords.Text = userDt.Rows.Count.ToString();

            List<int> comboItem = new List<int>();
            for (int i = 1; i <= sumPage; i++)
            {
                comboItem.Add(i);
            }
            cbx_pageNum.DataSource = comboItem;

            dgv_resultList.DataSource = GetNewDataTable().DefaultView;

        }

        private DataTable GetNewDataTable()
        {
            DataTable dt = userDt.Clone();
            for (int i = 20*(nowPage-1); i < (((nowPage*20)>(userDt.Rows.Count))?(userDt.Rows.Count):(nowPage * 20)); i++)
            {
                dt.Rows.Add(userDt.Rows[i].ItemArray);
            }
            return dt;
        }

        private void ClearTable()
        {
            DataTable dt = userDt.Clone();
            dgv_resultList.DataSource = dt;
        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            EditOrAddUser editUI = new EditOrAddUser(null);
            editUI.MdiParent = this.MdiParent;
            editUI.TopLevel = false;
            editUI.Parent = this.Parent;
            editUI.BringToFront();
            editUI.Show();

            
            ClearTable();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            InitCombobox();
            InitDataTable();

            AllFun.CheckAllCtrls(this);
            AllFun.ReplaceByLanguageMode();
        }

        private void InitDataTable()
        {
            
            userDt = new DataTable();
            userDt.Columns.Add("Email", Type.GetType("System.String"));
            userDt.Columns.Add("Name", Type.GetType("System.String"));
            userDt.Columns.Add("Gender", Type.GetType("System.String"));
            userDt.Columns.Add("DateOfBirth", Type.GetType("System.String"));
            userDt.Columns.Add("Phone", Type.GetType("System.String"));
            userDt.Columns.Add("Role", Type.GetType("System.String"));
            
        }

        private void InitCombobox()
        {
            cbx_role.DataSource = new List<String>() { "All", "Office User", "Administrator" };
            cbx_role.SelectedIndex = 0;
        }

        private void cbx_pageNum_TextChanged(object sender, EventArgs e)
        {
            if (IsInt(cbx_pageNum.Text))
            {
                if (int.Parse(cbx_pageNum.Text)>sumPage||int.Parse(cbx_pageNum.Text)<1)
                {
                    MessageBox.Show("输入的数字不正确");
                    return;
                }
                nowPage = int.Parse(cbx_pageNum.Text);
                ClearTable();
                dgv_resultList.DataSource = GetNewDataTable().DefaultView;
            }
        }

        private bool IsInt(string str)
        {
            try
            {
                int.Parse(str);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_resultList.CurrentRow!=null)
            {
                if (dgv_resultList.CurrentRow.Index!=-1)
                {
                    EditOrAddUser editUI = new EditOrAddUser(userList[(cbx_pageNum.SelectedIndex*20) + dgv_resultList.CurrentRow.Index]);
                    editUI.MdiParent = this.MdiParent;
                    editUI.TopLevel = false;
                    editUI.Parent = this.Parent;
                    editUI.BringToFront();
                    editUI.Show();
                    
                }
            }
            ClearTable();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
