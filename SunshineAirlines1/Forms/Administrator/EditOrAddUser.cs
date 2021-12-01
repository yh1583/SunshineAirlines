using SunshineAirlines1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using SunshineAirlines1.Dals;

namespace SunshineAirlines1.Forms.Administrator
{
    public partial class EditOrAddUser : Form
    {
        public EditOrAddUser(User u)
        {
            InitializeComponent();
            user = u;
        }
        private User user;

        private bool isAddMode;


        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txt_email.Text=="")
            {
                MessageBox.Show("邮箱不能为空");
            }
            else if (txt_fname.Text=="")
            {
                MessageBox.Show("姓不能为空");
            }
            else if (txt_lname.Text == "")
            {
                MessageBox.Show("名不能为空");
            }
            else if (txt_tel.Text == "")
            {
                MessageBox.Show("电话号码不能为空");
            }
            else if (!txt_email.Text.Contains('@'))
            {
                MessageBox.Show("邮箱格式不正确");
            }
            else
            {
                if (isAddMode)
                {
                    int i = UsersDal.RegistAcount(new User
                    {
                        Email = txt_email.Text,
                        FirstName = txt_fname.Text,
                        LastName = txt_lname.Text,
                        Password =
                        txt_email.Text.Split('@').Length < 6 ?
                        txt_email.Text.Split('@')[0] :
                        txt_email.Text.Split('@')[0].Substring(txt_email.Text.Split('@')[0].Length - 6, 6),
                        Gender = rbtn_male.Checked ? "M" : "F",
                        DateOfBirth=dtp_birth.Value,
                        Phone=txt_tel.Text,
                        Photo=PhotoImageInsert(pic_img.ImageLocation),
                        Address=txt_address.Text,
                        RoleId=rbtn_office.Checked?1:2

                    }) ;
                    if (i==1)
                    {
                        MessageBox.Show("添加用户成功");
                    }
                    else
                    {
                        MessageBox.Show("添加用户失败");
                    }
                }
                else
                {
                    int i = UsersDal.UpdateAcount(new User
                    {
                        Email = txt_email.Text,
                        FirstName = txt_fname.Text,
                        LastName = txt_lname.Text,
                        Password =
                       txt_email.Text.Split('@').Length < 6 ?
                       txt_email.Text.Split('@')[0] :
                       txt_email.Text.Split('@')[0].Substring(txt_email.Text.Split('@')[0].Length - 6, 6),
                        Gender = rbtn_male.Checked ? "M" : "F",
                        DateOfBirth = dtp_birth.Value,
                        Phone = txt_tel.Text,
                        Photo = PhotoImageInsert(pic_img.ImageLocation),
                        Address = txt_address.Text,
                        RoleId = rbtn_office.Checked ? 1 : 2,
                        UserId=user.UserId
                        
                    });
                    if (i == 1)
                    {
                        MessageBox.Show("修改用户成功");
                    }
                    else
                    {
                        MessageBox.Show("修改用户失败");
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter ="JPG文件|*.jpg";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(dialog.FileName);
                long size = fileInfo.Length;
                if (size>100*1024)
                {
                    MessageBox.Show("图片过大");
                    return;
                }
                try
                {
                    File.Copy(dialog.FileName, Application.StartupPath + @"\Images\userphoto\"+Path.GetFileName(dialog.FileName));
                }
                catch 
                {
                    
                }
                pic_img.Image = Image.FromFile(dialog.FileName);
                pic_img.ImageLocation = Application.StartupPath + @"\Images\userphoto\" + Path.GetFileName(dialog.FileName);
                pic_img.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void EditOrAddUser_Load(object sender, EventArgs e)
        {
            if (user==null)
            {
                isAddMode = true;
            }
            else
            {
                isAddMode = false;
                txt_email.Text = user.Email;
                txt_fname.Text = user.FirstName;
                txt_lname.Text = user.LastName;
                if (user.Gender=="M")
                {
                    rbtn_male.Checked = true;
                }
                else
                {
                    rbtn_female.Checked = true;
                }
                dtp_birth.Value = user.DateOfBirth;
                txt_tel.Text = user.Phone;
                if (user.Phone!=null)
                {
                    pic_img.Image = ReturnPhoto(user.Photo);
                    pic_img.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                txt_address.Text = user.Address;
                if (user.RoleId==1)
                {
                    rbtn_office.Checked = true;
                }
                else
                {
                    rbtn_admin.Checked = true;
                }


            }


            AllFun.CheckAllCtrls(this);
            AllFun.ReplaceByLanguageMode();
        }

        private Image ReturnPhoto(byte[] streamByte)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream(streamByte);
                Image img=Image.FromStream(memoryStream,true);
                return img;
            }
            catch 
            {
                return null;
            }
        }

        private byte[] PhotoImageInsert(string imagePath)
        {
            try
            {
                FileStream fs = new FileStream(imagePath,FileMode.Open,FileAccess.Read);
                byte[] image = new byte[fs.Length];
                fs.Read(image,0,Convert.ToInt32(fs.Length));
                fs.Close();
                return image;
            }
            catch 
            {
                return null;
            }
        }
    }
}
