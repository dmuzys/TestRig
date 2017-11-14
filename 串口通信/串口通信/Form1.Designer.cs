namespace 串口通信
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxFs = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.cbxTimeSend = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbxSend = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxJs = new System.Windows.Forms.GroupBox();
            this.tbxRecive = new System.Windows.Forms.TextBox();
            this.groupBoxCk = new System.Windows.Forms.GroupBox();
            this.rbnHex = new System.Windows.Forms.RadioButton();
            this.rbnChar = new System.Windows.Forms.RadioButton();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxComPorts = new System.Windows.Forms.ComboBox();
            this.btnComOpen = new System.Windows.Forms.Button();
            this.btnComCheck = new System.Windows.Forms.Button();
            this.labelSjw = new System.Windows.Forms.Label();
            this.labelJo = new System.Windows.Forms.Label();
            this.labelTzw = new System.Windows.Forms.Label();
            this.labelBtl = new System.Windows.Forms.Label();
            this.labelCkh = new System.Windows.Forms.Label();
            this.tmSend = new System.Windows.Forms.Timer(this.components);
            this.groupBoxFs.SuspendLayout();
            this.groupBoxJs.SuspendLayout();
            this.groupBoxCk.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFs
            // 
            this.groupBoxFs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxFs.Controls.Add(this.label1);
            this.groupBoxFs.Controls.Add(this.tbxTime);
            this.groupBoxFs.Controls.Add(this.cbxTimeSend);
            this.groupBoxFs.Controls.Add(this.btnSend);
            this.groupBoxFs.Controls.Add(this.tbxSend);
            this.groupBoxFs.Controls.Add(this.btnClear);
            this.groupBoxFs.Location = new System.Drawing.Point(54, 435);
            this.groupBoxFs.Name = "groupBoxFs";
            this.groupBoxFs.Size = new System.Drawing.Size(611, 184);
            this.groupBoxFs.TabIndex = 4;
            this.groupBoxFs.TabStop = false;
            this.groupBoxFs.Text = "数据发送";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "毫秒";
            // 
            // tbxTime
            // 
            this.tbxTime.Location = new System.Drawing.Point(205, 144);
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(100, 21);
            this.tbxTime.TabIndex = 12;
            // 
            // cbxTimeSend
            // 
            this.cbxTimeSend.AutoSize = true;
            this.cbxTimeSend.Location = new System.Drawing.Point(48, 148);
            this.cbxTimeSend.Name = "cbxTimeSend";
            this.cbxTimeSend.Size = new System.Drawing.Size(72, 16);
            this.cbxTimeSend.TabIndex = 11;
            this.cbxTimeSend.Text = "定时发送";
            this.cbxTimeSend.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(419, 142);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "发送数据";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbxSend
            // 
            this.tbxSend.Location = new System.Drawing.Point(6, 18);
            this.tbxSend.Multiline = true;
            this.tbxSend.Name = "tbxSend";
            this.tbxSend.Size = new System.Drawing.Size(599, 103);
            this.tbxSend.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(515, 142);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "清空数据";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBoxJs
            // 
            this.groupBoxJs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxJs.Controls.Add(this.tbxRecive);
            this.groupBoxJs.Location = new System.Drawing.Point(54, 219);
            this.groupBoxJs.Name = "groupBoxJs";
            this.groupBoxJs.Size = new System.Drawing.Size(611, 210);
            this.groupBoxJs.TabIndex = 3;
            this.groupBoxJs.TabStop = false;
            this.groupBoxJs.Text = "数据接收";
            // 
            // tbxRecive
            // 
            this.tbxRecive.Location = new System.Drawing.Point(6, 20);
            this.tbxRecive.Multiline = true;
            this.tbxRecive.Name = "tbxRecive";
            this.tbxRecive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxRecive.Size = new System.Drawing.Size(599, 184);
            this.tbxRecive.TabIndex = 0;
            // 
            // groupBoxCk
            // 
            this.groupBoxCk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxCk.Controls.Add(this.rbnHex);
            this.groupBoxCk.Controls.Add(this.rbnChar);
            this.groupBoxCk.Controls.Add(this.cbxDataBits);
            this.groupBoxCk.Controls.Add(this.cbxParity);
            this.groupBoxCk.Controls.Add(this.cbxStopBits);
            this.groupBoxCk.Controls.Add(this.cbxBaudRate);
            this.groupBoxCk.Controls.Add(this.cbxComPorts);
            this.groupBoxCk.Controls.Add(this.btnComOpen);
            this.groupBoxCk.Controls.Add(this.btnComCheck);
            this.groupBoxCk.Controls.Add(this.labelSjw);
            this.groupBoxCk.Controls.Add(this.labelJo);
            this.groupBoxCk.Controls.Add(this.labelTzw);
            this.groupBoxCk.Controls.Add(this.labelBtl);
            this.groupBoxCk.Controls.Add(this.labelCkh);
            this.groupBoxCk.Location = new System.Drawing.Point(54, 28);
            this.groupBoxCk.Name = "groupBoxCk";
            this.groupBoxCk.Size = new System.Drawing.Size(611, 185);
            this.groupBoxCk.TabIndex = 2;
            this.groupBoxCk.TabStop = false;
            this.groupBoxCk.Text = "串口设置";
            // 
            // rbnHex
            // 
            this.rbnHex.AutoSize = true;
            this.rbnHex.Location = new System.Drawing.Point(445, 147);
            this.rbnHex.Name = "rbnHex";
            this.rbnHex.Size = new System.Drawing.Size(65, 16);
            this.rbnHex.TabIndex = 15;
            this.rbnHex.TabStop = true;
            this.rbnHex.Text = "Hex显示";
            this.rbnHex.UseVisualStyleBackColor = true;
            // 
            // rbnChar
            // 
            this.rbnChar.AutoSize = true;
            this.rbnChar.Location = new System.Drawing.Point(313, 147);
            this.rbnChar.Name = "rbnChar";
            this.rbnChar.Size = new System.Drawing.Size(71, 16);
            this.rbnChar.TabIndex = 14;
            this.rbnChar.TabStop = true;
            this.rbnChar.Text = "字符显示";
            this.rbnChar.UseVisualStyleBackColor = true;
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Location = new System.Drawing.Point(313, 89);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(121, 20);
            this.cbxDataBits.TabIndex = 13;
            // 
            // cbxParity
            // 
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Location = new System.Drawing.Point(313, 35);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(121, 20);
            this.cbxParity.TabIndex = 12;
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Location = new System.Drawing.Point(93, 143);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(121, 20);
            this.cbxStopBits.TabIndex = 11;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(93, 89);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cbxBaudRate.TabIndex = 10;
            // 
            // cbxComPorts
            // 
            this.cbxComPorts.FormattingEnabled = true;
            this.cbxComPorts.Location = new System.Drawing.Point(93, 35);
            this.cbxComPorts.Name = "cbxComPorts";
            this.cbxComPorts.Size = new System.Drawing.Size(121, 20);
            this.cbxComPorts.TabIndex = 9;
            // 
            // btnComOpen
            // 
            this.btnComOpen.Location = new System.Drawing.Point(502, 86);
            this.btnComOpen.Name = "btnComOpen";
            this.btnComOpen.Size = new System.Drawing.Size(75, 23);
            this.btnComOpen.TabIndex = 8;
            this.btnComOpen.Text = "打开串口";
            this.btnComOpen.UseVisualStyleBackColor = true;
            this.btnComOpen.Click += new System.EventHandler(this.btnComOpen_Click);
            // 
            // btnComCheck
            // 
            this.btnComCheck.Location = new System.Drawing.Point(502, 37);
            this.btnComCheck.Name = "btnComCheck";
            this.btnComCheck.Size = new System.Drawing.Size(75, 23);
            this.btnComCheck.TabIndex = 7;
            this.btnComCheck.Text = "串口检测";
            this.btnComCheck.UseVisualStyleBackColor = true;
            this.btnComCheck.Click += new System.EventHandler(this.btnComCheck_Click);
            // 
            // labelSjw
            // 
            this.labelSjw.AutoSize = true;
            this.labelSjw.Location = new System.Drawing.Point(255, 92);
            this.labelSjw.Name = "labelSjw";
            this.labelSjw.Size = new System.Drawing.Size(41, 12);
            this.labelSjw.TabIndex = 4;
            this.labelSjw.Text = "数据位";
            // 
            // labelJo
            // 
            this.labelJo.AutoSize = true;
            this.labelJo.Location = new System.Drawing.Point(255, 38);
            this.labelJo.Name = "labelJo";
            this.labelJo.Size = new System.Drawing.Size(53, 12);
            this.labelJo.TabIndex = 3;
            this.labelJo.Text = "奇偶校验";
            // 
            // labelTzw
            // 
            this.labelTzw.AutoSize = true;
            this.labelTzw.Location = new System.Drawing.Point(46, 146);
            this.labelTzw.Name = "labelTzw";
            this.labelTzw.Size = new System.Drawing.Size(41, 12);
            this.labelTzw.TabIndex = 2;
            this.labelTzw.Text = "停止位";
            // 
            // labelBtl
            // 
            this.labelBtl.AutoSize = true;
            this.labelBtl.Location = new System.Drawing.Point(46, 92);
            this.labelBtl.Name = "labelBtl";
            this.labelBtl.Size = new System.Drawing.Size(41, 12);
            this.labelBtl.TabIndex = 1;
            this.labelBtl.Text = "波特率";
            // 
            // labelCkh
            // 
            this.labelCkh.AutoSize = true;
            this.labelCkh.Location = new System.Drawing.Point(46, 38);
            this.labelCkh.Name = "labelCkh";
            this.labelCkh.Size = new System.Drawing.Size(41, 12);
            this.labelCkh.TabIndex = 0;
            this.labelCkh.Text = "串口号";
            // 
            // tmSend
            // 
            this.tmSend.Tick += new System.EventHandler(this.tmSend_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 647);
            this.Controls.Add(this.groupBoxFs);
            this.Controls.Add(this.groupBoxJs);
            this.Controls.Add(this.groupBoxCk);
            this.Name = "Form1";
            this.Text = "串口";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFs.ResumeLayout(false);
            this.groupBoxFs.PerformLayout();
            this.groupBoxJs.ResumeLayout(false);
            this.groupBoxJs.PerformLayout();
            this.groupBoxCk.ResumeLayout(false);
            this.groupBoxCk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTime;
        private System.Windows.Forms.CheckBox cbxTimeSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBoxJs;
        private System.Windows.Forms.TextBox tbxRecive;
        private System.Windows.Forms.GroupBox groupBoxCk;
        private System.Windows.Forms.RadioButton rbnHex;
        private System.Windows.Forms.RadioButton rbnChar;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxComPorts;
        private System.Windows.Forms.Button btnComOpen;
        private System.Windows.Forms.Button btnComCheck;
        private System.Windows.Forms.Label labelSjw;
        private System.Windows.Forms.Label labelJo;
        private System.Windows.Forms.Label labelTzw;
        private System.Windows.Forms.Label labelBtl;
        private System.Windows.Forms.Label labelCkh;
        private System.Windows.Forms.Timer tmSend;
    }
}

