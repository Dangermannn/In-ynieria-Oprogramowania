﻿namespace SimpleCalculator.Forms
{
    partial class FormLength
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
            this.labelError = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelConvertTo = new System.Windows.Forms.Label();
            this.labelConvertFrom = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.comboBoxConvertTo = new System.Windows.Forms.ComboBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.comboBoxConvertFrom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(14, 184);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 17;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 150);
            this.labelResult.MaximumSize = new System.Drawing.Size(250, 0);
            this.labelResult.MinimumSize = new System.Drawing.Size(250, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(250, 13);
            this.labelResult.TabIndex = 16;
            // 
            // labelConvertTo
            // 
            this.labelConvertTo.AutoSize = true;
            this.labelConvertTo.Location = new System.Drawing.Point(9, 110);
            this.labelConvertTo.Name = "labelConvertTo";
            this.labelConvertTo.Size = new System.Drawing.Size(56, 13);
            this.labelConvertTo.TabIndex = 15;
            this.labelConvertTo.Text = "Convert to";
            // 
            // labelConvertFrom
            // 
            this.labelConvertFrom.AutoSize = true;
            this.labelConvertFrom.Location = new System.Drawing.Point(12, 60);
            this.labelConvertFrom.Name = "labelConvertFrom";
            this.labelConvertFrom.Size = new System.Drawing.Size(67, 13);
            this.labelConvertFrom.TabIndex = 14;
            this.labelConvertFrom.Text = "Convert from";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(12, 9);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(34, 13);
            this.labelValue.TabIndex = 13;
            this.labelValue.Text = "Value";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(197, 226);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 12;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // comboBoxConvertTo
            // 
            this.comboBoxConvertTo.FormattingEnabled = true;
            this.comboBoxConvertTo.Location = new System.Drawing.Point(12, 126);
            this.comboBoxConvertTo.Name = "comboBoxConvertTo";
            this.comboBoxConvertTo.Size = new System.Drawing.Size(260, 21);
            this.comboBoxConvertTo.TabIndex = 11;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(12, 26);
            this.textBoxValue.MaxLength = 8;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(260, 20);
            this.textBoxValue.TabIndex = 10;
            this.textBoxValue.TextChanged += new System.EventHandler(this.textBoxValue_TextChanged);
            // 
            // comboBoxConvertFrom
            // 
            this.comboBoxConvertFrom.FormattingEnabled = true;
            this.comboBoxConvertFrom.Location = new System.Drawing.Point(12, 76);
            this.comboBoxConvertFrom.Name = "comboBoxConvertFrom";
            this.comboBoxConvertFrom.Size = new System.Drawing.Size(260, 21);
            this.comboBoxConvertFrom.TabIndex = 9;
            // 
            // FormLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelConvertTo);
            this.Controls.Add(this.labelConvertFrom);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.comboBoxConvertTo);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.comboBoxConvertFrom);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormLength";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelConvertTo;
        private System.Windows.Forms.Label labelConvertFrom;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox comboBoxConvertTo;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.ComboBox comboBoxConvertFrom;
    }
}