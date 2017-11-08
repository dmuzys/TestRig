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
            this.textBoxActiveVoltage = new System.Windows.Forms.TextBox();
            this.textBoxActiveCurrent = new System.Windows.Forms.TextBox();
            this.textBoxActivePower = new System.Windows.Forms.TextBox();
            this.textBoxActiveFrequency = new System.Windows.Forms.TextBox();
            this.groupBoxLoadConvert = new System.Windows.Forms.GroupBox();
            this.labelLoadVoltage = new System.Windows.Forms.Label();
            this.labelLoadCurrent = new System.Windows.Forms.Label();
            this.labelLoadPower = new System.Windows.Forms.Label();
            this.labelLoadFrequency = new System.Windows.Forms.Label();
            this.textBoxLoadVoltage = new System.Windows.Forms.TextBox();
            this.textBoxLoadCurrent = new System.Windows.Forms.TextBox();
            this.textBoxLoadPower = new System.Windows.Forms.TextBox();
            this.textBoxLoadFrequency = new System.Windows.Forms.TextBox();
            this.groupBoxParameter = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.groupBoxActiveConvert.Controls.Add(this.textBoxActiveVoltage);
            this.groupBoxActiveConvert.Controls.Add(this.textBoxActiveCurrent);
            this.groupBoxActiveConvert.Controls.Add(this.textBoxActivePower);
            this.groupBoxActiveConvert.Controls.Add(this.textBoxActiveFrequency);
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
            // textBoxActiveVoltage
            // 
            this.textBoxActiveVoltage.Location = new System.Drawing.Point(150, 168);
            this.textBoxActiveVoltage.Name = "textBoxActiveVoltage";
            this.textBoxActiveVoltage.Size = new System.Drawing.Size(100, 21);
            this.textBoxActiveVoltage.TabIndex = 3;
            // 
            // textBoxActiveCurrent
            // 
            this.textBoxActiveCurrent.Location = new System.Drawing.Point(150, 120);
            this.textBoxActiveCurrent.Name = "textBoxActiveCurrent";
            this.textBoxActiveCurrent.Size = new System.Drawing.Size(100, 21);
            this.textBoxActiveCurrent.TabIndex = 2;
            // 
            // textBoxActivePower
            // 
            this.textBoxActivePower.Location = new System.Drawing.Point(150, 80);
            this.textBoxActivePower.Name = "textBoxActivePower";
            this.textBoxActivePower.Size = new System.Drawing.Size(100, 21);
            this.textBoxActivePower.TabIndex = 1;
            // 
            // textBoxActiveFrequency
            // 
            this.textBoxActiveFrequency.Location = new System.Drawing.Point(150, 36);
            this.textBoxActiveFrequency.Name = "textBoxActiveFrequency";
            this.textBoxActiveFrequency.Size = new System.Drawing.Size(100, 21);
            this.textBoxActiveFrequency.TabIndex = 0;
            // 
            // groupBoxLoadConvert
            // 
            this.groupBoxLoadConvert.Controls.Add(this.labelLoadVoltage);
            this.groupBoxLoadConvert.Controls.Add(this.labelLoadCurrent);
            this.groupBoxLoadConvert.Controls.Add(this.labelLoadPower);
            this.groupBoxLoadConvert.Controls.Add(this.labelLoadFrequency);
            this.groupBoxLoadConvert.Controls.Add(this.textBoxLoadVoltage);
            this.groupBoxLoadConvert.Controls.Add(this.textBoxLoadCurrent);
            this.groupBoxLoadConvert.Controls.Add(this.textBoxLoadPower);
            this.groupBoxLoadConvert.Controls.Add(this.textBoxLoadFrequency);
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
            // textBoxLoadVoltage
            // 
            this.textBoxLoadVoltage.Location = new System.Drawing.Point(162, 168);
            this.textBoxLoadVoltage.Name = "textBoxLoadVoltage";
            this.textBoxLoadVoltage.Size = new System.Drawing.Size(100, 21);
            this.textBoxLoadVoltage.TabIndex = 3;
            // 
            // textBoxLoadCurrent
            // 
            this.textBoxLoadCurrent.Location = new System.Drawing.Point(162, 120);
            this.textBoxLoadCurrent.Name = "textBoxLoadCurrent";
            this.textBoxLoadCurrent.Size = new System.Drawing.Size(100, 21);
            this.textBoxLoadCurrent.TabIndex = 2;
            // 
            // textBoxLoadPower
            // 
            this.textBoxLoadPower.Location = new System.Drawing.Point(162, 74);
            this.textBoxLoadPower.Name = "textBoxLoadPower";
            this.textBoxLoadPower.Size = new System.Drawing.Size(100, 21);
            this.textBoxLoadPower.TabIndex = 1;
            // 
            // textBoxLoadFrequency
            // 
            this.textBoxLoadFrequency.Location = new System.Drawing.Point(162, 35);
            this.textBoxLoadFrequency.Name = "textBoxLoadFrequency";
            this.textBoxLoadFrequency.Size = new System.Drawing.Size(100, 21);
            this.textBoxLoadFrequency.TabIndex = 0;
            // 
            // groupBoxParameter
            // 
            this.groupBoxParameter.Controls.Add(this.textBox3);
            this.groupBoxParameter.Controls.Add(this.textBox2);
            this.groupBoxParameter.Controls.Add(this.textBox1);
            this.groupBoxParameter.Controls.Add(this.button2);
            this.groupBoxParameter.Controls.Add(this.button1);
            this.groupBoxParameter.Controls.Add(this.comboBox5);
            this.groupBoxParameter.Controls.Add(this.comboBox4);
            this.groupBoxParameter.Controls.Add(this.comboBox3);
            this.groupBoxParameter.Controls.Add(this.comboBox2);
            this.groupBoxParameter.Controls.Add(this.comboBox1);
            this.groupBoxParameter.Location = new System.Drawing.Point(679, 12);
            this.groupBoxParameter.Name = "groupBoxParameter";
            this.groupBoxParameter.Size = new System.Drawing.Size(972, 226);
            this.groupBoxParameter.TabIndex = 3;
            this.groupBoxParameter.TabStop = false;
            this.groupBoxParameter.Text = "参数设置";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(73, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(73, 163);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(281, 33);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 20);
            this.comboBox4.TabIndex = 3;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(281, 98);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 20);
            this.comboBox5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(470, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(470, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(470, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 806);
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

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxImage;
        private System.Windows.Forms.GroupBox groupBoxActiveConvert;
        private System.Windows.Forms.TextBox textBoxActiveVoltage;
        private System.Windows.Forms.TextBox textBoxActiveCurrent;
        private System.Windows.Forms.TextBox textBoxActivePower;
        private System.Windows.Forms.TextBox textBoxActiveFrequency;
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
        private System.Windows.Forms.TextBox textBoxLoadVoltage;
        private System.Windows.Forms.TextBox textBoxLoadCurrent;
        private System.Windows.Forms.TextBox textBoxLoadPower;
        private System.Windows.Forms.TextBox textBoxLoadFrequency;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

