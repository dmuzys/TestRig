namespace DataBaseXXX
{
    partial class SearchData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.tbxCondition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowData
            // 
            this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowData.Location = new System.Drawing.Point(12, 70);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.RowTemplate.Height = 23;
            this.dgvShowData.Size = new System.Drawing.Size(886, 434);
            this.dgvShowData.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(666, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(793, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbxDate
            // 
            this.tbxDate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxDate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxDate.Location = new System.Drawing.Point(81, 29);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(100, 21);
            this.tbxDate.TabIndex = 3;
            // 
            // tbxCondition
            // 
            this.tbxCondition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxCondition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxCondition.Location = new System.Drawing.Point(294, 29);
            this.tbxCondition.Name = "tbxCondition";
            this.tbxCondition.Size = new System.Drawing.Size(315, 21);
            this.tbxCondition.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "时间日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "实验条件：";
            // 
            // SearchData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxCondition);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvShowData);
            this.Name = "SearchData";
            this.Text = "SearchData";
            this.Load += new System.EventHandler(this.SearchData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.TextBox tbxCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}