namespace DataBaseXXX
{
    partial class ShowDataBase
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
            this.livDataBase = new System.Windows.Forms.ListView();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.tbxCondition = new System.Windows.Forms.TextBox();
            this.tbxElectric = new System.Windows.Forms.TextBox();
            this.tbxVoltage = new System.Windows.Forms.TextBox();
            this.tbxSpeed = new System.Windows.Forms.TextBox();
            this.tbxTorque = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // livDataBase
            // 
            this.livDataBase.FullRowSelect = true;
            this.livDataBase.Location = new System.Drawing.Point(315, 12);
            this.livDataBase.Name = "livDataBase";
            this.livDataBase.Size = new System.Drawing.Size(1054, 473);
            this.livDataBase.TabIndex = 0;
            this.livDataBase.UseCompatibleStateImageBehavior = false;
            this.livDataBase.View = System.Windows.Forms.View.Details;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(125, 553);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveData.TabIndex = 1;
            this.btnSaveData.Text = "保存数据";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // tbxCondition
            // 
            this.tbxCondition.Location = new System.Drawing.Point(153, 45);
            this.tbxCondition.Name = "tbxCondition";
            this.tbxCondition.Size = new System.Drawing.Size(100, 21);
            this.tbxCondition.TabIndex = 2;
            // 
            // tbxElectric
            // 
            this.tbxElectric.Location = new System.Drawing.Point(153, 131);
            this.tbxElectric.Name = "tbxElectric";
            this.tbxElectric.Size = new System.Drawing.Size(100, 21);
            this.tbxElectric.TabIndex = 3;
            // 
            // tbxVoltage
            // 
            this.tbxVoltage.Location = new System.Drawing.Point(153, 217);
            this.tbxVoltage.Name = "tbxVoltage";
            this.tbxVoltage.Size = new System.Drawing.Size(100, 21);
            this.tbxVoltage.TabIndex = 4;
            // 
            // tbxSpeed
            // 
            this.tbxSpeed.Location = new System.Drawing.Point(153, 303);
            this.tbxSpeed.Name = "tbxSpeed";
            this.tbxSpeed.Size = new System.Drawing.Size(100, 21);
            this.tbxSpeed.TabIndex = 5;
            // 
            // tbxTorque
            // 
            this.tbxTorque.Location = new System.Drawing.Point(153, 389);
            this.tbxTorque.Name = "tbxTorque";
            this.tbxTorque.Size = new System.Drawing.Size(100, 21);
            this.tbxTorque.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "条件";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "电流";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "电压";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "转速";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "扭矩";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(561, 553);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "修改数据";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(779, 553);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "删除数据";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(343, 553);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "查询数据";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ShowDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 616);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTorque);
            this.Controls.Add(this.tbxSpeed);
            this.Controls.Add(this.tbxVoltage);
            this.Controls.Add(this.tbxElectric);
            this.Controls.Add(this.tbxCondition);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.livDataBase);
            this.Name = "ShowDataBase";
            this.Text = "ShowDataBase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView livDataBase;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.TextBox tbxCondition;
        private System.Windows.Forms.TextBox tbxElectric;
        private System.Windows.Forms.TextBox tbxVoltage;
        private System.Windows.Forms.TextBox tbxSpeed;
        private System.Windows.Forms.TextBox tbxTorque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
    }
}

