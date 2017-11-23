using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace DataBaseXXX
{
    public partial class EditData : Form
    {

        private string StrConn = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];

        //重载修改窗体构造函数
        private int ID;
        public EditData(int id)
        {
            InitializeComponent();
            ID = id;
        }

        //读取并显示在窗体上
        private void EditData_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(StrConn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = ("select * from Data where ID ='" + ID.ToString() + "'");
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tbxEditCondition.Text = Convert.ToString(reader["ExperimentCondition"]);
                }
                reader.Close();
                conn.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "出错提示");
            }
        }

        //修改按钮
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string ExperimentCondition;
            if (tbxEditCondition.Text == "")
            {
                MessageBox.Show("实验条件不能为空", "提示：");
                return;
            }
            else
            {
                ExperimentCondition = tbxEditCondition.Text.Trim();
            }

            try
            {
                SqlConnection conn = new SqlConnection(StrConn);
                SqlCommand cmdedit = new SqlCommand();
                cmdedit.Connection = conn;
                conn.Open();
                //更新
                cmdedit.CommandText = "update Data set ExperimentCondition=@ExperimentCondition ";
                cmdedit.CommandText += "where ID=@ID";

                cmdedit.Parameters.Add("@ID", SqlDbType.Int);
                cmdedit.Parameters.Add("@ExperimentCondition", SqlDbType.VarChar, 50);

                cmdedit.Parameters["@ID"].Value = ID;
                cmdedit.Parameters["@ExperimentCondition"].Value = ExperimentCondition;

                cmdedit.ExecuteNonQuery();
                conn.Close();
                DialogResult = DialogResult.OK;
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "出错提示");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
