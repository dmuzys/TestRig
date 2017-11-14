using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace 串口通信
{
    public partial class Form1 : Form
    {
        SerialPort sp = null;   //声明一个串口类
        bool isOpen = false;    //打开串口标志位
        bool isSetProperty = false;   //属性设置标志位
        bool isHex = false;     //十六进制显示标志位

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            for (int i = 0; i < 10; i++)    //串口支持最大到10 
            {
                cbxComPorts.Items.Add("com" + (i + 1).ToString());
            }
            cbxComPorts.SelectedIndex = 0;   //索引值从0开始 未选中为-1

            //列出波特率
            cbxBaudRate.Items.Add("1200");
            cbxBaudRate.Items.Add("2400");
            cbxBaudRate.Items.Add("4800");
            cbxBaudRate.Items.Add("9600");
            cbxBaudRate.Items.Add("19200");
            cbxBaudRate.Items.Add("38400");
            cbxBaudRate.Items.Add("43000");
            cbxBaudRate.Items.Add("56000");
            cbxBaudRate.Items.Add("57600");
            cbxBaudRate.Items.Add("115200");
            cbxBaudRate.SelectedIndex = 5;

            //列出停止位
            cbxStopBits.Items.Add("0");
            cbxStopBits.Items.Add("1");
            cbxStopBits.Items.Add("1.5");
            cbxStopBits.Items.Add("2");
            cbxStopBits.SelectedIndex = 1;

            //列出数据位
            cbxDataBits.Items.Add("8");
            cbxDataBits.Items.Add("7");
            cbxDataBits.Items.Add("6");
            cbxDataBits.Items.Add("5");
            cbxDataBits.SelectedIndex = 0;

            //列出奇偶校验位
            cbxParity.Items.Add("无");
            cbxParity.Items.Add("奇校验");
            cbxParity.Items.Add("偶校验");
            cbxParity.SelectedIndex = 0;

            //默认为char 字符显示
            rbnChar.Checked = true;
        }

        // 检查串口按钮
        private void btnComCheck_Click(object sender, EventArgs e)
        {
            bool comExistence = false;    //有可用串口标志位
            cbxComPorts.Items.Clear();    //清空串口名称
            for (int i = 0; i < 0; i++)
            {
                try     //try catch 用来报错
                {
                    SerialPort sp = new SerialPort("com" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                   cbxComPorts.Items.Add("com" + (i + 1).ToString());
                    comExistence = true;
                }
                catch (Exception)
                {
                    continue;
                }
                if (comExistence)
                {
                    cbxComPorts.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("没有可用串口！", "错误提示");
                }
            }
        }

        private bool CheckPortSetting()   //定义一个布尔函数  检查串口设置   //并非所有代码都路径返回值 如果成立一个结果  如果不成立一个结果
        {                                         //如果 5个条件均成立 才可以返回true！ 可以不用else
            if (cbxComPorts.Text.Trim() == "")   //Trim（）函数用来去掉字符前面的空格
                return false;
            if (cbxBaudRate.Text.Trim() == "")
                return false;
            if (cbxStopBits.Text.Trim() == "")
                return false;
            if (cbxParity.Text.Trim() == "")
                return false;
            if (cbxDataBits.Text.Trim() == "")
                return false;
            return true;
        }

        private bool CheckSendData()   //定义一个布尔函数  检查发送数据
        {
            if (tbxSend.Text == "")
                return false;
            return true;
        }

        //设置串口属性
        private void SetPortProperty()    
        {
            sp = new SerialPort();
            sp.PortName = cbxComPorts.Text.Trim();  //设置串口名字
            sp.BaudRate = Convert.ToInt32(cbxBaudRate.Text.Trim());     //将其他类型强制转化为32位整数类型 整形数据

            float f = Convert.ToSingle(cbxStopBits.Text.Trim());       //设置停止位    single为32为单精度浮点数
            if (f == 0)
            {
                sp.StopBits = StopBits.None;
            }
            else if (f == 1.5)
            {
                sp.StopBits = StopBits.OnePointFive;
            }
            else if (f == 2)
            {
                sp.StopBits = StopBits.Two;
            }
            else
            {
                sp.StopBits = StopBits.One;
            }

            sp.DataBits = Convert.ToInt16(cbxDataBits.Text.Trim());    //设置数据位

            string s = cbxParity.Text.Trim();    //定义一个类 设置奇偶校验位
            if (s.CompareTo("无") == 0)     //比较 如果相等返回值为0 用来判断选择的奇偶校验位
            {
                sp.Parity = Parity.None;
            }
            else if (s.CompareTo("奇校验") == 0)
            {
                sp.Parity = Parity.Odd;
            }
            else if (s.CompareTo("偶校验") == 0)
            {
                sp.Parity = Parity.Even;
            }
            else
            {
                sp.Parity = Parity.None;
            }

            sp.ReadTimeout = -1;       //设置超时读取时间
            sp.RtsEnable = true;      //启用请求发送信号

            //定义DataReceived 事件，当串口收到数据后触发事件
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            {
                if (rbnHex.Checked)
                {
                    isHex = true;
                }
                else
                {
                    isHex = false;
                }
            }
        }

        //发送数据按钮
        private void btnSend_Click(object sender, EventArgs e) 
        {
            if (cbxTimeSend.Checked)
            {
                tmSend.Enabled = true;
            }
            else
            {
                tmSend.Enabled = false;
            }
            if (isOpen)   //isopen 打开串口   判断是否打开串口
            {
                try
                {
                    sp.WriteLine(tbxSend.Text);  //向 TextStream 文件写入指定字符串和新行字符 通过readline读取发送的数据
                }
                catch (Exception)
                {
                    MessageBox.Show("发送数据时发生错误！", "错误提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "错误提示");
                return;
            }
            if (!CheckSendData())
            {
                MessageBox.Show("请输入发送的数据", "错误提示");
                return;
            }
        }

        //打开串口
        private void btnComOpen_Click(object sender, EventArgs e)  
        {
            if (isOpen == false)
            {
                if (!CheckPortSetting())   //检查串口设置
                {
                    MessageBox.Show("串口未设置", "错误提示");
                    return;
                }
                if (!isSetProperty)     //定义的是否设置串口 用来判断串口是否设置
                {
                    SetPortProperty();
                    isSetProperty = true;
                }
                try                     //打开串口
                {
                    sp.Open();
                    isOpen = true;
                    btnComOpen.Text = "关闭串口";

                    //打开串口后其它选项无法选择
                    cbxComPorts.Enabled = false;
                    cbxBaudRate.Enabled = false;
                    cbxDataBits.Enabled = false;
                    cbxStopBits.Enabled = false;
                    cbxParity.Enabled = false;
                    rbnChar.Enabled = false;
                    rbnHex.Enabled = false;
                }
                catch (Exception)
                {
                    //打开串口失败后
                    isSetProperty = false;
                    isOpen = false;
                    MessageBox.Show("串口打开失败", "错误提示");
                }
            }
            else    //如果串口没打开 显示打开串口
            {
                try     //关闭串口
                {
                    sp.Close();
                    isOpen = false;
                    btnComOpen.Text = "打开串口";

                    cbxComPorts.Enabled = true;
                    cbxBaudRate.Enabled = true;
                    cbxDataBits.Enabled = true;
                    cbxStopBits.Enabled = true;
                    cbxParity.Enabled = true;
                    rbnChar.Enabled = true;
                    rbnHex.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("关闭串口错误", "错误提示");
                }

            }
        }

        //清空发送数据
        private void btnClear_Click(object sender, EventArgs e) 
        {
            tbxSend.Text = "";
            tbxRecive.Text = "";
        }

        //接收数据
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e) 
        {
            System.Threading.Thread.Sleep(100);//延时100ms 等待接收完数据
                                               //this.Invoke 就是跨线程访问ui 的方法，也是本文的范例
            this.Invoke((EventHandler)(delegate
            {
                if (isHex == false)
                {
                    tbxRecive.Text += sp.ReadLine();
                }
                else
                {
                    Byte[] ReceivedData = new Byte[sp.BytesToRead]; //创建接收字节数组
                    sp.Read(ReceivedData, 0, ReceivedData.Length); //读取所接收到的数据
                    String RecvDataText = null;
                    for (int i = 0; i < ReceivedData.Length - 1; i++)
                    {
                        RecvDataText += ("0x" + ReceivedData[i].ToString("X2") + " ");
                    }
                    tbxRecive.Text += RecvDataText;
                }
                sp.DiscardInBuffer();//丢弃接收缓冲区数据
            }));
        }

        //定时器
        private void tmSend_Tick(object sender, EventArgs e)
        {
            string strTime = tbxTime.Text;
            int time = int.Parse(strTime);
            tmSend.Interval = time;

            if (tmSend.Enabled == true)
                btnSend.PerformClick();
        }

    }
}
