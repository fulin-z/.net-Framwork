using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMGS.database
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
    }
}
