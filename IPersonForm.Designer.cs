﻿namespace HourlyManagment
{
    partial class IPersonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            // 
            // IPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = global::HourlyManagment.Properties.Resources.Hourglass;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "IPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.JobTextBox = new System.Windows.Forms.ComboBox();
            this.AdditionalInfoTextBox = new System.Windows.Forms.TextBox();
            this.DegreeTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.RankComboBox = new System.Windows.Forms.ComboBox();
            this.ForeignCheckBox = new System.Windows.Forms.CheckBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.WorkPlaceTextBox = new System.Windows.Forms.ComboBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.JobTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AdditionalInfoTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.DegreeTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GenderComboBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.RankComboBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ForeignCheckBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.FullNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.WorkPlaceTextBox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 428);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // JobTextBox
            // 
            this.JobTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.JobTextBox.FormattingEnabled = true;
            this.JobTextBox.Items.AddRange(new object[] {
            "",
            "викладач",
            "старший викладач",
            "доцент",
            "професор"});
            this.JobTextBox.Location = new System.Drawing.Point(123, 98);
            this.JobTextBox.Name = "JobTextBox";
            this.JobTextBox.Size = new System.Drawing.Size(374, 31);
            this.JobTextBox.TabIndex = 3;
            // 
            // AdditionalInfoTextBox
            // 
            this.AdditionalInfoTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AdditionalInfoTextBox.Location = new System.Drawing.Point(123, 393);
            this.AdditionalInfoTextBox.Name = "AdditionalInfoTextBox";
            this.AdditionalInfoTextBox.Size = new System.Drawing.Size(374, 32);
            this.AdditionalInfoTextBox.TabIndex = 22;
            // 
            // DegreeTextBox
            // 
            this.DegreeTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DegreeTextBox.Location = new System.Drawing.Point(123, 337);
            this.DegreeTextBox.Name = "DegreeTextBox";
            this.DegreeTextBox.Size = new System.Drawing.Size(374, 32);
            this.DegreeTextBox.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 372);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 56);
            this.label15.TabIndex = 14;
            this.label15.Text = "Додаткова інформація";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 50);
            this.label13.TabIndex = 12;
            this.label13.Text = "Науковий ступінь";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 50);
            this.label11.TabIndex = 10;
            this.label11.Text = "Вчене звання";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 50);
            this.label9.TabIndex = 8;
            this.label9.Text = "Стать";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 50);
            this.label7.TabIndex = 6;
            this.label7.Text = "Зовнішній?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "Місце основної роботи";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Посада";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПІБ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "чоловіча",
            "жіноча"});
            this.GenderComboBox.Location = new System.Drawing.Point(123, 248);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(374, 31);
            this.GenderComboBox.TabIndex = 15;
            // 
            // RankComboBox
            // 
            this.RankComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RankComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RankComboBox.FormattingEnabled = true;
            this.RankComboBox.Items.AddRange(new object[] {
            " ",
            "доцент",
            "професор"});
            this.RankComboBox.Location = new System.Drawing.Point(123, 298);
            this.RankComboBox.Name = "RankComboBox";
            this.RankComboBox.Size = new System.Drawing.Size(374, 31);
            this.RankComboBox.TabIndex = 16;
            // 
            // ForeignCheckBox
            // 
            this.ForeignCheckBox.AutoSize = true;
            this.ForeignCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ForeignCheckBox.Location = new System.Drawing.Point(123, 192);
            this.ForeignCheckBox.Name = "ForeignCheckBox";
            this.ForeignCheckBox.Size = new System.Drawing.Size(374, 27);
            this.ForeignCheckBox.TabIndex = 17;
            this.ForeignCheckBox.Text = " ";
            this.ForeignCheckBox.UseVisualStyleBackColor = true;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FullNameTextBox.Location = new System.Drawing.Point(123, 37);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(374, 32);
            this.FullNameTextBox.TabIndex = 18;
            // 
            // WorkPlaceTextBox
            // 
            this.WorkPlaceTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WorkPlaceTextBox.FormattingEnabled = true;
            this.WorkPlaceTextBox.Location = new System.Drawing.Point(123, 148);
            this.WorkPlaceTextBox.Name = "WorkPlaceTextBox";
            this.WorkPlaceTextBox.Size = new System.Drawing.Size(374, 31);
            this.WorkPlaceTextBox.TabIndex = 23;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitBtn.Location = new System.Drawing.Point(193, 466);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(108, 39);
            this.SubmitBtn.TabIndex = 2;
            this.SubmitBtn.Text = "Оновити";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            

        }

        #endregion

        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.Button SubmitBtn;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.Label label11;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox AdditionalInfoTextBox;
        protected System.Windows.Forms.TextBox DegreeTextBox;
        protected System.Windows.Forms.ComboBox GenderComboBox;
        protected System.Windows.Forms.ComboBox RankComboBox;
        protected System.Windows.Forms.CheckBox ForeignCheckBox;
        protected System.Windows.Forms.TextBox FullNameTextBox;
        protected System.Windows.Forms.ComboBox JobTextBox;
        protected System.Windows.Forms.ComboBox WorkPlaceTextBox;
    }
}