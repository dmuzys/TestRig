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
using System.Configuration;
using System.IO;

namespace DataBaseXXX
{
    public partial class ShowDataBase : Form
    {
        //使用连接字符串
        private string StrConn = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];

        public ShowDataBase()
        {
            InitializeComponent();
        }

        //加载窗体程序  
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            LoadList();
        }

        //定义loadlist方法 用于加载信息到listview1中 
        private void LoadList()
        {
            try
            {

                livDataBase.Clear();
                livDataBase.Columns.Add("日期时间", 150, HorizontalAlignment.Center);    //长度150 居中
                livDataBase.Columns.Add("实验条件", 350, HorizontalAlignment.Center);
                livDataBase.Columns.Add("电流", 150, HorizontalAlignment.Center);
                livDataBase.Columns.Add("电压", 150, HorizontalAlignment.Center);
                livDataBase.Columns.Add("转速", 150, HorizontalAlignment.Center);
                livDataBase.Columns.Add("扭矩", 150, HorizontalAlignment.Center);

                //使用DataReader读取信息
                SqlConnection conn = new SqlConnection(StrConn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select ID,DateTime,ExperimentCondition,Electric,Voltage,Speed,Torque from Data";
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                int count = 0;
                while (sdr.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = sdr["DateTime"].ToString();
                    lvi.SubItems.Add(sdr["ExperimentCondition"].ToString());
                    lvi.SubItems.Add(sdr["Electric"].ToString());
                    lvi.SubItems.Add(sdr["Voltage"].ToString());
                    lvi.SubItems.Add(sdr["Speed"].ToString());
                    lvi.SubItems.Add(sdr["Torque"].ToString());
                    lvi.Tag = sdr["ID"];

                    livDataBase.Items.Add(lvi);
                    count++;
                }
                sdr.Close();
                conn.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "出错提示");
            }
        }

        //存储数据按钮
        private void btnSaveData_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(StrConn);
            conn.Open();

            //存储tbx中的数据into到Data表中
            SqlCommand cmd = new SqlCommand("insert into Data values ('" + DateTime.Now.ToString() + "','" + tbxCondition.Text.Trim() + "','" + tbxElectric.Text.Trim() + "','" + tbxVoltage.Text.Trim() + "','" + tbxSpeed.Text.Trim() + "','" + tbxTorque.Text.Trim() + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            //将数据显示出来
            LoadList();

        }

        //添加删除信息方法
        private void Delete()
        {

            if (livDataBase.SelectedItems.Count < 1)            //如果选中的行小于1 返回
            {
                MessageBox.Show("请先选中要删除的选项！", "提示：");
                return;
            }

            if (MessageBox.Show("是否删除选中记录？", "提示：", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)     //提示框并点击确定继续执行
            {
                //通过循环确定删除选项的执行语句
                string strWhere = "where ID in(";
                foreach (ListViewItem lvi in livDataBase.SelectedItems)   //循环语句 用于处理集合或数组
                {
                    strWhere += lvi.Tag.ToString() + ",";
                }
                strWhere = strWhere.Substring(0, strWhere.Length - 1);
                strWhere += ")";

                try
                {
                    SqlConnection conn = new SqlConnection(StrConn);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from Data " + strWhere;
                    conn.Open();
                    cmd.ExecuteNonQuery();     //执行commandtext命令
                    conn.Close();

                    LoadList();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "出错提示");
                }
            }
        }

        //删除按钮
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        //定义 Edit编辑 方法
        private void Edit()
        {
            if (livDataBase.SelectedItems.Count == 1)
            {
                int id = Convert.ToInt32(livDataBase.SelectedItems[0].Tag);
                EditData e = new EditData(id);
                if (e.ShowDialog(this) == DialogResult.OK)
                {
                    LoadList();
                }
            }
            else
            {
                MessageBox.Show("请选择一项", "提示");
            }
        }

        //编辑按钮
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        //定义 Search搜索 方法
        private void Search()
        {
            //显示搜索数据窗体
            SearchData s = new SearchData();
            s.ShowDialog();
        }

        //查询数据按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
