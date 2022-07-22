namespace Activity_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_pounds = new System.Windows.Forms.Label();
            this.lbl_kilograms = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.tbx_pounds = new System.Windows.Forms.TextBox();
            this.tbx_kilograms = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_pounds
            // 
            this.lbl_pounds.AutoSize = true;
            this.lbl_pounds.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pounds.Location = new System.Drawing.Point(94, 105);
            this.lbl_pounds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pounds.Name = "lbl_pounds";
            this.lbl_pounds.Size = new System.Drawing.Size(245, 30);
            this.lbl_pounds.TabIndex = 0;
            this.lbl_pounds.Text = "Your weight in pounds";
            // 
            // lbl_kilograms
            // 
            this.lbl_kilograms.AutoSize = true;
            this.lbl_kilograms.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_kilograms.Location = new System.Drawing.Point(69, 175);
            this.lbl_kilograms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_kilograms.Name = "lbl_kilograms";
            this.lbl_kilograms.Size = new System.Drawing.Size(270, 30);
            this.lbl_kilograms.TabIndex = 1;
            this.lbl_kilograms.Text = "Your weight in kilograms";
            this.lbl_kilograms.Click += new System.EventHandler(this.lbl_kilograms_Click);
            // 
            // btn_convert
            // 
            this.btn_convert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_convert.Location = new System.Drawing.Point(365, 239);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(100, 34);
            this.btn_convert.TabIndex = 2;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // tbx_pounds
            // 
            this.tbx_pounds.Location = new System.Drawing.Point(365, 114);
            this.tbx_pounds.Name = "tbx_pounds";
            this.tbx_pounds.Size = new System.Drawing.Size(100, 22);
            this.tbx_pounds.TabIndex = 3;
            // 
            // tbx_kilograms
            // 
            this.tbx_kilograms.Location = new System.Drawing.Point(365, 183);
            this.tbx_kilograms.Name = "tbx_kilograms";
            this.tbx_kilograms.Size = new System.Drawing.Size(100, 22);
            this.tbx_kilograms.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.tbx_kilograms);
            this.Controls.Add(this.tbx_pounds);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.lbl_kilograms);
            this.Controls.Add(this.lbl_pounds);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_pounds;
        private Label lbl_kilograms;
        private Button btn_convert;
        private TextBox tbx_pounds;
        private TextBox tbx_kilograms;
    }
}