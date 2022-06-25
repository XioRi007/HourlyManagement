namespace HourlyManagment
{
    partial class SearchForm
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
            this.SearchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkPlaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTypeComboBox
            // 
            this.SearchTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchTypeComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTypeComboBox.FormattingEnabled = true;
            this.SearchTypeComboBox.Items.AddRange(new object[] {
            "за ПІБ",
            "за підрозділом"});
            this.SearchTypeComboBox.Location = new System.Drawing.Point(519, 37);
            this.SearchTypeComboBox.Name = "SearchTypeComboBox";
            this.SearchTypeComboBox.Size = new System.Drawing.Size(244, 31);
            this.SearchTypeComboBox.TabIndex = 0;
            this.SearchTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchTypeComboBox_SelectedIndexChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(463, 124);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(340, 32);
            this.SearchTextBox.TabIndex = 1;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitBtn.Location = new System.Drawing.Point(595, 207);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(93, 39);
            this.SubmitBtn.TabIndex = 2;
            this.SubmitBtn.Text = "Пошук";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Location = new System.Drawing.Point(321, 124);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(690, 31);
            this.SearchComboBox.TabIndex = 4;
            this.SearchComboBox.Visible = false;
            this.SearchComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 421);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullNameColumn,
            this.JobColumn,
            this.WorkPlaceColumn,
            this.BtnColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1280, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.HeaderText = "ПІБ";
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            this.FullNameColumn.Width = 350;
            // 
            // JobColumn
            // 
            this.JobColumn.HeaderText = "Посада";
            this.JobColumn.Name = "JobColumn";
            this.JobColumn.ReadOnly = true;
            this.JobColumn.Width = 275;
            // 
            // WorkPlaceColumn
            // 
            this.WorkPlaceColumn.HeaderText = "Місце основної роботи";
            this.WorkPlaceColumn.Name = "WorkPlaceColumn";
            this.WorkPlaceColumn.ReadOnly = true;
            this.WorkPlaceColumn.Width = 480;
            // 
            // BtnColumn
            // 
            this.BtnColumn.HeaderText = " ";
            this.BtnColumn.Name = "BtnColumn";
            this.BtnColumn.ReadOnly = true;
            this.BtnColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BtnColumn.Width = 115;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchComboBox);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchTypeComboBox);
            this.Icon = global::HourlyManagment.Properties.Resources.Hourglass;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пошук";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchForm_FormClosed);
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SearchTypeComboBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkPlaceColumn;
        private System.Windows.Forms.DataGridViewButtonColumn BtnColumn;
    }
}