using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.DataBase
{
    class DataOperate
    {
        DataCon datacon = new DataCon();//声明DataCon类的一个对象，以调用其方法

        #region  绑定ComboBox控件
        /// <summary>
        /// 对ComboBox控件进行数据绑定
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
        /// <param name="M_str_table">表名</param>
        /// <param name="M_str_tbMember">数据表中字段名</param>
        /// <param name="cbox">ComboBox控件ID</param>
        public void cboxBind(string M_str_sqlstr, string M_str_table, string M_str_tbMember, ComboBox cbox)
        {
            DataSet myds = datacon.getds(M_str_sqlstr, M_str_table);
            cbox.DataSource = myds.Tables[M_str_table];
            cbox.DisplayMember = M_str_tbMember;
        }
        #endregion

        #region 将图片转为二进制
        public void SaveImage(string MID, OpenFileDialog openF)//将图片以二进制存入数据库中
        {
            SqlConnection conn = datacon.getcon();
            string strimg = openF.FileName.ToString();  //记录图片的所在路径
            FileStream fs = new FileStream(strimg, FileMode.Open, FileAccess.Read); //将图片以文件流的形式进行保存
            BinaryReader br = new BinaryReader(fs);
            byte[] imgBytesIn = br.ReadBytes((int)fs.Length);  //将流读入到字节数组中
            conn.Open();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_Employee Set EmPhoto=@Photo where EmployeeID=" + MID);
            SqlCommand cmd = new SqlCommand(strSql.ToString(), conn);
            cmd.Parameters.Add("@Photo", SqlDbType.Binary).Value = imgBytesIn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        #endregion

        #region 取出图片
        public void Get_Image(string ygname, PictureBox pb)//将图片从数据库中取出
        {
            SqlConnection conn = datacon.getcon();
            byte[] imagebytes = null;
            conn.Open();
            SqlCommand com = new SqlCommand("select * from tb_Employee where EmployeeID='" + ygname + "'", conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                imagebytes = (byte[])dr.GetValue(16);
            }
            dr.Close();
            conn.Close();
            MemoryStream ms = new MemoryStream(imagebytes);
            Bitmap bmpt = new Bitmap(ms);
            pb.Image = bmpt;
        }
        #endregion

        #region 显示选择的图片
        public void Read_Image(OpenFileDialog openF, PictureBox MyImage)  //显示选择的图片
        {
            openF.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";   //指定OpenFileDialog控件打开的文件格式
            if (openF.ShowDialog() == DialogResult.OK)  //如果打开了图片文件
            {
                try
                {
                    MyImage.Image = System.Drawing.Image.FromFile(openF.FileName);  //将图片文件存入到PictureBox控件中
                }
                catch
                {
                    MessageBox.Show("您选择的图片不能被读取或文件类型不对！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region 计算个人所得税

        public decimal GRSDS(int pay)//个人所得税计算
        {
            decimal tax = 0;//个人所得税
            int Y = pay - 1600;//计税工资=每月工资-1600
            if (pay <= 1600)
            {
                tax = 0;
            }
            else
            {
                if (Y >= 0 || Y <= 500)
                {
                    tax = (decimal)(Y * 0.05);
                }
                else
                {
                    if (Y > 500 || Y <= 2000)
                    {
                        tax = (decimal)(Y * 0.1 - 25);
                    }
                    else
                    {
                        if (Y > 2000 || Y <= 5000)
                        {
                            tax = (decimal)(Y * 0.15 - 125);
                        }
                        else
                        {
                            if (Y > 5000 || Y <= 20000)
                            {
                                tax = (decimal)(Y * 0.2 - 375);
                            }
                            else
                            {
                                if (Y > 20000 || Y <= 40000)
                                {
                                    tax = (decimal)(Y * 0.25 - 1375);
                                }
                                else
                                {
                                    if (Y > 40000 || Y <= 60000)
                                    {
                                        tax = (decimal)(Y * 0.3 - 3375);
                                    }
                                    else
                                    {
                                        if (Y > 60000 || Y <= 80000)
                                        {
                                            tax = (decimal)(Y * 0.35 - 6375);
                                        }
                                        else
                                        {
                                            if (Y > 80000 || Y <= 100000)
                                            {
                                                tax = (decimal)(Y * 0.4 - 10375);
                                            }
                                            else
                                            {
                                                if (Y > 100000)
                                                {
                                                    tax = (decimal)(Y * 0.45 - 15375);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return tax;
        }
        #endregion
    }
}
