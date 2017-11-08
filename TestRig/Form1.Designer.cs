namespace TestRig
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxImage = new System.Windows.Forms.GroupBox();
            this.groupBoxActiveConvert = new System.Windows.Forms.GroupBox();
            this.labelActiveVoltage = new System.Windows.Forms.Label();
            this.labelActiveCurrent = new System.Windows.Forms.Label();
            this.labelActivePower = new System.Windows.Forms.Label();
            this.labelActiveFrequency = new System.Windows.Forms.Label();
            this.tbxActiveVoltage = new System.Windows.Forms.TextBox();
            this.tbxActiveCurrent = new System.Windows.Forms.TextBox();
            this.tbxActivePower = new System.Windows.Forms.TextBox();
            this.tbxActiveFrequency = new System.Windows.Forms.TextBox();
            this.groupBoxLoadConvert = new System.Windows.Forms.GroupBox();
            this.labelLoadVoltage = new System.Windows.Forms.Label();
            this.labelLoadCurrent = new System.Windows.Forms.Label();
            this.labelLoadPower = new System.Windows.Forms.Label();
            this.labelLoadFrequency = new System.Windows.Forms.Label();
            this.tbxLoadVoltage = new System.Windows.Forms.TextBox();
            this.tbxLoadCurrent = new System.Windows.Forms.TextBox();
            this.tbxLoadPower = new System.Windows.Forms.TextBox();
            this.tbxLoadFrequency = new System.Windows.Forms.TextBox();
            this.groupBoxParameter = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnComOpen = new System.Windows.Forms.Button();
            this.btnComCheck = new System.Windows.Forms.Button();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxComPort = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxActiveConvert.SuspendLayout();
            this.groupBoxLoadConvert.SuspendLayout();
            this.groupBoxParameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxImage
            // 
            this.groupBoxImage.BackgroundImage = global::TestRig.Properties.Resources.sun;
            this.groupBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBoxImage.Location = new System.Drawing.Point(12, 12);
            this.groupBoxImage.Name = "groupBoxImage";
            this.groupBoxImage.Size = new System.Drawing.Size(643, 445);
            this.groupBoxImage.TabIndex = 0;
            this.groupBoxImage.TabStop = false;
            this.groupBoxImage.Text = "工作示意图";
            // 
            // groupBoxActiveConvert
            // 
            this.groupBoxActiveConvert.Controls.Add(this.labelActiveVoltage);
            this.groupBoxActiveConvert.Controls.Add(this.labelActiveCurrent);
            this.groupBoxActiveConvert.Controls.Add(this.labelActivePower);
            this.groupBoxActiveConvert.Controls.Add(this.labelActiveFrequency);
            this.groupBoxActiveConvert.Controls.Add(this.tbxActiveVoltage);
            this.groupBoxActiveConvert.Controls.Add(this.tbxActiveCurrent);
            this.groupBoxActiveConvert.Controls.Add(this.tbxActivePower);
            this.groupBoxActiveConvert.Controls.Add(this.tbxActiveFrequency);
            this.groupBoxActiveConvert.Location = new System.Drawing.Point(679, 244);
            this.groupBoxActiveConvert.Name = "groupBoxActiveConvert";
            this.groupBoxActiveConvert.Size = new System.Drawing.Size(314, 213);
            this.groupBoxActiveConvert.TabIndex = 1;
            this.groupBoxActiveConvert.TabStop = false;
            this.groupBoxActiveConvert.Text = "主动变频器输出参数";
            // 
            // labelActiveVoltage
            // 
            this.labelActiveVoltage.AutoSize = true;
            this.labelActiveVoltage.Location = new System.Drawing.Point(66, 177);
            this.labelActiveVoltage.Name = "labelActiveVoltage";
            this.labelActiveVoltage.Size = new System.Drawing.Size(53, 12);
            this.labelActiveVoltage.TabIndex = 7;
            this.labelActiveVoltage.Text = "输出电压";
            // 
            // labelActiveCurrent
            // 
            this.labelActiveCurrent.AutoSize = true;
            this.labelActiveCurrent.Location = new System.Drawing.Point(66, 129);
            this.labelActiveCurrent.Name = "labelActiveCurrent";
            this.labelActiveCurrent.Size = new System.Drawing.Size(53, 12);
            this.labelActiveCurrent.TabIndex = 6;
            this.labelActiveCurrent.Text = "输出电流";
            // 
            // labelActivePower
            // 
            this.labelActivePower.AutoSize = true;
            this.labelActivePower.Location = new System.Drawing.Point(66, 83);
            this.labelActivePower.Name = "labelActivePower";
            this.labelActivePower.Size = new System.Drawing.Size(53, 12);
            this.labelActivePower.TabIndex = 5;
            this.labelActivePower.Text = "输出功率";
            // 
            // labelActiveFrequency
            // 
            this.labelActiveFrequency.AutoSize = true;
            this.labelActiveFrequency.Location = new System.Drawing.Point(66, 44);
            this.labelActiveFrequency.Name = "labelActiveFrequency";
            this.labelActiveFrequency.Size = new System.Drawing.Size(53, 12);
            this.labelActiveFrequency.TabIndex = 4;
            this.labelActiveFrequency.Text = "输出频率";
            // 
            // tbxActiveVoltage
            // 
            this.tbxActiveVoltage.Location = new System.Drawing.Point(150, 168);
            this.tbxActiveVoltage.Name = "tbxActiveVoltage";
            this.tbxActiveVoltage.Size = new System.Drawing.Size(100, 21);
            this.tbxActiveVoltage.TabIndex = 3;
            // 
            // tbxActiveCurrent
            // 
            this.tbxActiveCurrent.Location = new System.Drawing.Point(150, 120);
            this.tbxActiveCurrent.Name = "tbxActiveCurrent";
            this.tbxActiveCurrent.Size = new System.Drawing.Size(100, 21);
            this.tbxActiveCurrent.TabIndex = 2;
            // 
            // tbxActivePower
            // 
            this.tbxActivePower.Location = new System.Drawing.Point(150, 80);
            this.tbxActivePower.Name = "tbxActivePower";
            this.tbxActivePower.Size = new System.Drawing.Size(100, 21);
            this.tbxActivePower.TabIndex = 1;
            // 
            // tbxActiveFrequency
            // 
            this.tbxActiveFrequency.Location = new System.Drawing.Point(150, 36);
            this.tbxActiveFrequency.Name = "tbxActiveFrequency";
            this.tbxActiveFrequency.Size = new System.Drawing.Size(100, 21);
            this.tbxActiveFrequency.TabIndex = 0;
            // 
            // groupBoxLoadConvert
            // 
            this.groupBoxLoadConvert.Controls.Add(this.labelLoadVoltage);
            this.groupBoxLoadConvert.Controls.Add(this.labelLoadCurrent);
            this.groupBoxLoadConvert.Controls.Add(this.labelLoadPower);
            this.groupBoxLoadConvert.Controls.Add(this.labelLoadFrequency);
            this.groupBoxLoadConvert.Controls.Add(this.tbxLoadVoltage);
            this.groupBoxLoadConvert.Controls.Add(this.tbxLoadCurrent);
            this.groupBoxLoadConvert.Controls.Add(this.tbxLoadPower);
            this.groupBoxLoadConvert.Controls.Add(this.tbxLoadFrequency);
            this.groupBoxLoadConvert.Location = new System.Drawing.Point(1012, 244);
            this.groupBoxLoadConvert.Name = "groupBoxLoadConvert";
            this.groupBoxLoadConvert.Size = new System.Drawing.Size(314, 213);
            this.groupBoxLoadConvert.TabIndex = 2;
            this.groupBoxLoadConvert.TabStop = false;
            this.groupBoxLoadConvert.Text = "负载变频器输出参数";
            // 
            // labelLoadVoltage
            // 
            this.labelLoadVoltage.AutoSize = true;
            this.labelLoadVoltage.Location = new System.Drawing.Point(91, 168);
            this.labelLoadVoltage.Name = "labelLoadVoltage";
            this.labelLoadVoltage.Size = new System.Drawing.Size(53, 12);
            this.labelLoadVoltage.TabIndex = 7;
            this.labelLoadVoltage.Text = "输出电压";
            // 
            // labelLoadCurrent
            // 
            this.labelLoadCurrent.AutoSize = true;
            this.labelLoadCurrent.Location = new System.Drawing.Point(91, 123);
            this.labelLoadCurrent.Name = "labelLoadCurrent";
            this.labelLoadCurrent.Size = new System.Drawing.Size(53, 12);
            this.labelLoadCurrent.TabIndex = 6;
            this.labelLoadCurrent.Text = "输出电流";
            // 
            // labelLoadPower
            // 
            this.labelLoadPower.AutoSize = true;
            this.labelLoadPower.Location = new System.Drawing.Point(91, 80);
            this.labelLoadPower.Name = "labelLoadPower";
            this.labelLoadPower.Size = new System.Drawing.Size(53, 12);
            this.labelLoadPower.TabIndex = 5;
            this.labelLoadPower.Text = "输出功率";
            // 
            // labelLoadFrequency
            // 
            this.labelLoadFrequency.AutoSize = true;
            this.labelLoadFrequency.Location = new System.Drawing.Point(91, 44);
            this.labelLoadFrequency.Name = "labelLoadFrequency";
            this.labelLoadFrequency.Size = new System.Drawing.Size(53, 12);
            this.labelLoadFrequency.TabIndex = 4;
            this.labelLoadFrequency.Text = "输出频率";
            // 
            // tbxLoadVoltage
            // 
            this.tbxLoadVoltage.Location = new System.Drawing.Point(162, 168);
            this.tbxLoadVoltage.Name = "tbxLoadVoltage";
            this.tbxLoadVoltage.Size = new System.Drawing.Size(100, 21);
            this.tbxLoadVoltage.TabIndex = 3;
            // 
            // tbxLoadCurrent
            // 
            this.tbxLoadCurrent.Location = new System.Drawing.Point(162, 120);
            this.tbxLoadCurrent.Name = "tbxLoadCurrent";
            this.tbxLoadCurrent.Size = new System.Drawing.Size(100, 21);
            this.tbxLoadCurrent.TabIndex = 2;
            // 
            // tbxLoadPower
            // 
            this.tbxLoadPower.Location = new System.Drawing.Point(162, 74);
            this.tbxLoadPower.Name = "tbxLoadPower";
            this.tbxLoadPower.Size = new System.Drawing.Size(100, 21);
            this.tbxLoadPower.TabIndex = 1;
            // 
            // tbxLoadFrequency
            // 
            this.tbxLoadFrequency.Location = new System.Drawing.Point(162, 35);
            this.tbxLoadFrequency.Name = "tbxLoadFrequency";
            this.tbxLoadFrequency.Size = new System.Drawing.Size(100, 21);
            this.tbxLoadFrequency.TabIndex = 0;
            // 
            // groupBoxParameter
            // 
            this.groupBoxParameter.Controls.Add(this.label11);
            this.groupBoxParameter.Controls.Add(this.label10);
            this.groupBoxParameter.Controls.Add(this.label9);
            this.groupBoxParameter.Controls.Add(this.label8);
            this.groupBoxParameter.Controls.Add(this.label7);
            this.groupBoxParameter.Controls.Add(this.label6);
            this.groupBoxParameter.Controls.Add(this.textBox4);
            this.groupBoxParameter.Controls.Add(this.textBox5);
            this.groupBoxParameter.Controls.Add(this.textBox6);
            this.groupBoxParameter.Controls.Add(this.label5);
            this.groupBoxParameter.Controls.Add(this.label4);
            this.groupBoxParameter.Controls.Add(this.label3);
            this.groupBoxParameter.Controls.Add(this.label2);
            this.groupBoxParameter.Controls.Add(this.label1);
            this.groupBoxParameter.Controls.Add(this.textBox3);
            this.groupBoxParameter.Controls.Add(this.textBox2);
            this.groupBoxParameter.Controls.Add(this.textBox1);
            this.groupBoxParameter.Controls.Add(this.btnComOpen);
            this.groupBoxParameter.Controls.Add(this.btnComCheck);
            this.groupBoxParameter.Controls.Add(this.cbxDataBits);
            this.groupBoxParameter.Controls.Add(this.cbxParity);
            this.groupBoxParameter.Controls.Add(this.cbxStopBits);
            this.groupBoxParameter.Controls.Add(this.cbxBaudRate);
            this.groupBoxParameter.Controls.Add(this.cbxComPort);
            this.groupBoxParameter.Location = new System.Drawing.Point(679, 12);
            this.groupBoxParameter.Name = "groupBoxParameter";
            this.groupBoxParameter.Size = new System.Drawing.Size(972, 226);
            this.groupBoxParameter.TabIndex = 3;
            this.groupBoxParameter.TabStop = false;
            this.groupBoxParameter.Text = "参数设置";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(726, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "实验条件";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(493, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "实验名称";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(702, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "试验持续时间";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "试验编号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(720, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "试验模式";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "设备类型";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(795, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(795, 97);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(795, 32);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "数据位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "奇偶校验";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "停止位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "串口号";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(563, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(563, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(563, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 7;
            // 
            // btnComOpen
            // 
            this.btnComOpen.Location = new System.Drawing.Point(327, 160);
            this.btnComOpen.Name = "btnComOpen";
            this.btnComOpen.Size = new System.Drawing.Size(75, 23);
            this.btnComOpen.TabIndex = 6;
            this.btnComOpen.Text = "打开串口";
            this.btnComOpen.UseVisualStyleBackColor = true;
            // 
            // btnComCheck
            // 
            this.btnComCheck.Location = new System.Drawing.Point(228, 160);
            this.btnComCheck.Name = "btnComCheck";
            this.btnComCheck.Size = new System.Drawing.Size(75, 23);
            this.btnComCheck.TabIndex = 5;
            this.btnComCheck.Text = "串口检测";
            this.btnComCheck.UseVisualStyleBackColor = true;
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Location = new System.Drawing.Point(281, 98);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(121, 20);
            this.cbxDataBits.TabIndex = 4;
            // 
            // cbxParity
            // 
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Location = new System.Drawing.Point(281, 33);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(121, 20);
            this.cbxParity.TabIndex = 3;
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Location = new System.Drawing.Point(73, 163);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(121, 20);
            this.cbxStopBits.TabIndex = 2;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(73, 98);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cbxBaudRate.TabIndex = 1;
            // 
            // cbxComPort
            // 
            this.cbxComPort.FormattingEnabled = true;
            this.cbxComPort.Location = new System.Drawing.Point(73, 33);
            this.cbxComPort.Name = "cbxComPort";
            this.cbxComPort.Size = new System.Drawing.Size(121, 20);
            this.cbxComPort.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(553, 651);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "这里显示图像";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1474, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "一些操作按钮";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 806);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBoxParameter);
            this.Controls.Add(this.groupBoxLoadConvert);
            this.Controls.Add(this.groupBoxActiveConvert);
            this.Controls.Add(this.groupBoxImage);
            this.Name = "Form1";
            this.Text = "test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxActiveConvert.ResumeLayout(false);
            this.groupBoxActiveConvert.PerformLayout();
            this.groupBoxLoadConvert.ResumeLayout(false);
            this.groupBoxLoadConvert.PerformLayout();
            this.groupBoxParameter.ResumeLayout(false);
            this.groupBoxParameter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxImage;
        private System.Windows.Forms.GroupBox groupBoxActiveConvert;
        private System.Windows.Forms.TextBox tbxActiveVoltage;
        private System.Windows.Forms.TextBox tbxActiveCurrent;
        private System.Windows.Forms.TextBox tbxActivePower;
        private System.Windows.Forms.TextBox tbxActiveFrequency;
        private System.Windows.Forms.GroupBox groupBoxLoadConvert;
        private System.Windows.Forms.GroupBox groupBoxParameter;
        private System.Windows.Forms.Label labelActiveVoltage;
        private System.Windows.Forms.Label labelActiveCurrent;
        private System.Windows.Forms.Label labelActivePower;
        private System.Windows.Forms.Label labelActiveFrequency;
        private System.Windows.Forms.Label labelLoadVoltage;
        private System.Windows.Forms.Label labelLoadCurrent;
        private System.Windows.Forms.Label labelLoadPower;
        private System.Windows.Forms.Label labelLoadFrequency;
        private System.Windows.Forms.TextBox tbxLoadVoltage;
        private System.Windows.Forms.TextBox tbxLoadCurrent;
        private System.Windows.Forms.TextBox tbxLoadPower;
        private System.Windows.Forms.TextBox tbxLoadFrequency;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnComOpen;
        private System.Windows.Forms.Button btnComCheck;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxComPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

