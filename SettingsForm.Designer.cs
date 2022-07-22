namespace HourlyManagment
{
    partial class SettingsForm
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
            this.firstSignCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fontSizeCB = new System.Windows.Forms.ComboBox();
            this.fontCB = new System.Windows.Forms.ComboBox();
            this.SignsExtractsCB = new System.Windows.Forms.ComboBox();
            this.addTemplateButton = new System.Windows.Forms.Button();
            this.clearTemplateButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstSignCB
            // 
            this.firstSignCB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.firstSignCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firstSignCB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstSignCB.FormattingEnabled = true;
            this.firstSignCB.Items.AddRange(new object[] {
            "Ректор",
            "Перший проректор"});
            this.firstSignCB.Location = new System.Drawing.Point(156, 66);
            this.firstSignCB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.firstSignCB.Name = "firstSignCB";
            this.firstSignCB.Size = new System.Drawing.Size(257, 31);
            this.firstSignCB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Хто має право першого підпису?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Хто підписує витяги?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Шрифт";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "Розмір шрифту";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.fontSizeCB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.fontCB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SignsExtractsCB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.firstSignCB, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(419, 409);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // fontSizeCB
            // 
            this.fontSizeCB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fontSizeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontSizeCB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontSizeCB.FormattingEnabled = true;
            this.fontSizeCB.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14"});
            this.fontSizeCB.Location = new System.Drawing.Point(156, 373);
            this.fontSizeCB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.fontSizeCB.Name = "fontSizeCB";
            this.fontSizeCB.Size = new System.Drawing.Size(257, 31);
            this.fontSizeCB.TabIndex = 7;
            // 
            // fontCB
            // 
            this.fontCB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fontCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontCB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontCB.FormattingEnabled = true;
            this.fontCB.Items.AddRange(new object[] {
            "Times New Roman"});
            this.fontCB.Location = new System.Drawing.Point(156, 270);
            this.fontCB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.fontCB.Name = "fontCB";
            this.fontCB.Size = new System.Drawing.Size(257, 31);
            this.fontCB.TabIndex = 6;
            // 
            // SignsExtractsCB
            // 
            this.SignsExtractsCB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SignsExtractsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SignsExtractsCB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignsExtractsCB.FormattingEnabled = true;
            this.SignsExtractsCB.Items.AddRange(new object[] {
            "Начальник ВК",
            "Заступник начальника ВК"});
            this.SignsExtractsCB.Location = new System.Drawing.Point(156, 168);
            this.SignsExtractsCB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SignsExtractsCB.Name = "SignsExtractsCB";
            this.SignsExtractsCB.Size = new System.Drawing.Size(257, 31);
            this.SignsExtractsCB.TabIndex = 5;
            // 
            // addTemplateButton
            // 
            this.addTemplateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTemplateButton.Location = new System.Drawing.Point(12, 444);
            this.addTemplateButton.Name = "addTemplateButton";
            this.addTemplateButton.Size = new System.Drawing.Size(176, 52);
            this.addTemplateButton.TabIndex = 6;
            this.addTemplateButton.Text = "Додати шаблон";
            this.addTemplateButton.UseVisualStyleBackColor = true;
            this.addTemplateButton.Click += new System.EventHandler(this.addTemplateButton_Click);
            // 
            // clearTemplateButton
            // 
            this.clearTemplateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearTemplateButton.Location = new System.Drawing.Point(221, 444);
            this.clearTemplateButton.Name = "clearTemplateButton";
            this.clearTemplateButton.Size = new System.Drawing.Size(186, 52);
            this.clearTemplateButton.TabIndex = 7;
            this.clearTemplateButton.Text = "Видалити шаблон";
            this.clearTemplateButton.UseVisualStyleBackColor = true;
            this.clearTemplateButton.Click += new System.EventHandler(this.clearTemplateButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(419, 523);
            this.Controls.Add(this.clearTemplateButton);
            this.Controls.Add(this.addTemplateButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SettingsForm";
            this.Icon = global::HourlyManagment.Properties.Resources.Hourglass;
            this.Text = "Налаштування";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox firstSignCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox fontSizeCB;
        private System.Windows.Forms.ComboBox fontCB;
        private System.Windows.Forms.ComboBox SignsExtractsCB;
        private System.Windows.Forms.Button addTemplateButton;
        private System.Windows.Forms.Button clearTemplateButton;
    }
}