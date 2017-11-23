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
namespace DataBaseXXX
{
    public partial class SearchData : Form
    {
        public SearchData()
        {
            InitializeComponent();
        }

        string SearchStr;
        //定义连接字符串
        private string StrConn = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];

        //查询按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbxDate.Text == "" & tbxCondition.Text == "")
                {
                    MessageBox.Show("请添加查询内容", "提示");
                    return;
                }

                if (tbxDate.Text.Trim() != "" & tbxCondition.Text.Trim() == "")
                {
                    SearchStr = "select DateTime as 时间日期 ,ExperimentCondition as 实验条件,Electric as 电流,Voltage as 电压,Speed as 转速,Torque as 扭矩 from Data where DateTime Like '%'+'"+tbxDate.Text.Trim()+"'+'%'";
                }

                if (tbxDate.Text.Trim() == "" & tbxCondition.Text.Trim() != "")
                {
                    SearchStr = "select DateTime as 时间日期 ,ExperimentCondition as 实验条件,Electric as 电流,Voltage as 电压,Speed as 转速,Torque as 扭矩 from Data where ExperimentCondition Like '%'+'"+tbxCondition.Text.Trim()+"'+'%'";
                }

                if (tbxDate.Text.Trim() != "" & tbxCondition.Text.Trim() != "")
                {
                    SearchStr = "select DateTime as 时间日期 ,ExperimentCondition as 实验条件,Electric as 电流,Voltage as 电压,Speed as 转速,Torque as 扭矩 from Data where DateTime Like '%'+'" + tbxDate.Text.Trim() + "'+''%' and ExperimentCondition Like '%'+'" + tbxCondition.Text.Trim() + "'+'%'";
                }
                

                SqlConnection conn = new SqlConnection(StrConn);
                SqlCommand cmd = new SqlCommand(SearchStr,conn);
             
                cmd.Parameters.Add("@DateTime", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@ExperimentCondition", SqlDbType.VarChar, 50);
                cmd.Parameters["@DateTime"].Value = tbxDate.Text.Trim();
                cmd.Parameters["@ExperimentCondition"].Value = tbxCondition.Text.Trim();

                //使用datagridview控件显示数据库
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable mytable = new DataTable();
                mytable.Load(reader);
                dgvShowData.DataSource = mytable;
                reader.Close();
                conn.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "出错提示");
            }
        }

        //文本框自动提示功能
        private void SearchData_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(StrConn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText= "select DateTime,ExperimentCondition from Data";
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tbxDate.AutoCompleteCustomSource.Add(reader["DateTime"].ToString());
                    tbxCondition.AutoCompleteCustomSource.Add(reader["ExperimentCondition"].ToString());
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "出错提示");
            }
        }

        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
