using System.Drawing;

namespace HourlyManagment
{
    partial class CreateDocumentForm
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.DocumentComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submitBtn.Location = new System.Drawing.Point(5, 55);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(225, 40);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Створити";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // DocumentComboBox
            // 
            this.DocumentComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocumentComboBox.FormattingEnabled = true;
            this.DocumentComboBox.Location = new System.Drawing.Point(5, 5);
            this.DocumentComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.DocumentComboBox.Name = "DocumentComboBox";
            this.DocumentComboBox.Size = new System.Drawing.Size(225, 29);
            this.DocumentComboBox.TabIndex = 2;
            this.DocumentComboBox.SelectedIndexChanged += new System.EventHandler(this.DocumentComboBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.DocumentComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.submitBtn, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(135, 199);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 100);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // CreateDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = global::HourlyManagment.Properties.Resources.Hourglass;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateDocumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Створити наказ";
            this.Load += new System.EventHandler(this.CreateDocumentForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.ComboBox DocumentComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}