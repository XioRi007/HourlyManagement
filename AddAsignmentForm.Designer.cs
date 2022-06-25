namespace HourlyManagment
{
    partial class AddAsignmentForm
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
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.DateFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.JobComboBox = new System.Windows.Forms.ComboBox();
            this.PurposeComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DocumentDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DocumentNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitBtn.Location = new System.Drawing.Point(203, 489);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(106, 41);
            this.SubmitBtn.TabIndex = 0;
            this.SubmitBtn.Text = "Додати";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "прийом",
            "звільнення",
            "зменшення",
            "збільшення",
            "продовження"});
            this.TypeComboBox.Location = new System.Drawing.Point(126, 14);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(364, 31);
            this.TypeComboBox.TabIndex = 1;
            // 
            // DateFromDateTimePicker
            // 
            this.DateFromDateTimePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DateFromDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateFromDateTimePicker.Location = new System.Drawing.Point(126, 63);
            this.DateFromDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DateFromDateTimePicker.Name = "DateFromDateTimePicker";
            this.DateFromDateTimePicker.Size = new System.Drawing.Size(364, 32);
            this.DateFromDateTimePicker.TabIndex = 2;
            // 
            // DateToDateTimePicker
            // 
            this.DateToDateTimePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DateToDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateToDateTimePicker.Location = new System.Drawing.Point(126, 113);
            this.DateToDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DateToDateTimePicker.Name = "DateToDateTimePicker";
            this.DateToDateTimePicker.Size = new System.Drawing.Size(364, 32);
            this.DateToDateTimePicker.TabIndex = 3;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepartmentComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(126, 214);
            this.DepartmentComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(364, 31);
            this.DepartmentComboBox.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.JobComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PurposeComboBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TypeComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DocumentDateDateTimePicker, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.DocumentNumberTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.DateFromDateTimePicker, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DateToDateTimePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DepartmentComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HoursTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11012F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11123F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 457);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // JobComboBox
            // 
            this.JobComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.JobComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JobComboBox.FormattingEnabled = true;
            this.JobComboBox.Items.AddRange(new object[] {
            "",
            "асистент",
            "викладач",
            "голова",
            "старший викладач",
            "доцент",
            "професор",
            "член"});
            this.JobComboBox.Location = new System.Drawing.Point(126, 164);
            this.JobComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.JobComboBox.Name = "JobComboBox";
            this.JobComboBox.Size = new System.Drawing.Size(364, 31);
            this.JobComboBox.TabIndex = 18;
            // 
            // PurposeComboBox
            // 
            this.PurposeComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PurposeComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PurposeComboBox.FormattingEnabled = true;
            this.PurposeComboBox.Location = new System.Drawing.Point(126, 264);
            this.PurposeComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PurposeComboBox.Name = "PurposeComboBox";
            this.PurposeComboBox.Size = new System.Drawing.Size(364, 31);
            this.PurposeComboBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 57);
            this.label8.TabIndex = 16;
            this.label8.Text = "Дата наказу";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 50);
            this.label7.TabIndex = 15;
            this.label7.Text = "Номер наказу";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 50);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ціль";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 50);
            this.label5.TabIndex = 13;
            this.label5.Text = "Підрозділ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 50);
            this.label4.TabIndex = 12;
            this.label4.Text = "Посада";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 50);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата до";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 50);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата з";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DocumentDateDateTimePicker
            // 
            this.DocumentDateDateTimePicker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DocumentDateDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocumentDateDateTimePicker.Location = new System.Drawing.Point(126, 420);
            this.DocumentDateDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DocumentDateDateTimePicker.Name = "DocumentDateDateTimePicker";
            this.DocumentDateDateTimePicker.Size = new System.Drawing.Size(364, 32);
            this.DocumentDateDateTimePicker.TabIndex = 4;
            // 
            // DocumentNumberTextBox
            // 
            this.DocumentNumberTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DocumentNumberTextBox.Location = new System.Drawing.Point(123, 365);
            this.DocumentNumberTextBox.Name = "DocumentNumberTextBox";
            this.DocumentNumberTextBox.Size = new System.Drawing.Size(370, 32);
            this.DocumentNumberTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Тип";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HoursTextBox.Location = new System.Drawing.Point(123, 315);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(370, 32);
            this.HoursTextBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 50);
            this.label9.TabIndex = 20;
            this.label9.Text = "Години";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddAsignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(496, 574);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.SubmitBtn);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = global::HourlyManagment.Properties.Resources.Hourglass;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AddAsignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати призначення";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddAsignmentForm_FormClosed);
            this.Load += new System.EventHandler(this.AddAsignmentForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.DateTimePicker DateFromDateTimePicker;
        private System.Windows.Forms.DateTimePicker DateToDateTimePicker;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PurposeComboBox;
        private System.Windows.Forms.ComboBox JobComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DocumentDateDateTimePicker;
        private System.Windows.Forms.TextBox DocumentNumberTextBox;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.Label label9;
    }
}