﻿namespace mCopernicus
{
    partial class urlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urlForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.urlTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.urlButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Controls.Add(this.urlTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.urlButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Depth = 0;
            this.urlTextBox.Hint = "";
            this.urlTextBox.Location = new System.Drawing.Point(3, 9);
            this.urlTextBox.MaxLength = 32767;
            this.urlTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.PasswordChar = '\0';
            this.urlTextBox.SelectedText = "";
            this.urlTextBox.SelectionLength = 0;
            this.urlTextBox.SelectionStart = 0;
            this.urlTextBox.Size = new System.Drawing.Size(302, 29);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.TabStop = false;
            this.urlTextBox.UseSystemPasswordChar = false;
            this.urlTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.urlTextBox_MouseDown);
            // 
            // urlButton
            // 
            this.urlButton.AutoSize = true;
            this.urlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.urlButton.Depth = 0;
            this.urlButton.Icon = global::mCopernicus.Properties.Resources.send;
            this.urlButton.Location = new System.Drawing.Point(312, 6);
            this.urlButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.urlButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.urlButton.Name = "urlButton";
            this.urlButton.Primary = false;
            this.urlButton.Size = new System.Drawing.Size(41, 36);
            this.urlButton.TabIndex = 1;
            this.urlButton.UseVisualStyleBackColor = true;
            this.urlButton.Click += new System.EventHandler(this.urlButton_Click);
            // 
            // urlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 73);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "urlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "从SS URL导入";
            this.Load += new System.EventHandler(this.urlForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField urlTextBox;
        private MaterialSkin.Controls.MaterialFlatButton urlButton;
    }
}