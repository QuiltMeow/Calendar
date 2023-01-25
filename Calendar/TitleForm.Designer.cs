namespace Calendar
{
    partial class TitleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleForm));
            this.labelRoCYear = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRoCYear
            // 
            this.labelRoCYear.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelRoCYear.ForeColor = System.Drawing.Color.DarkRed;
            this.labelRoCYear.Location = new System.Drawing.Point(12, 9);
            this.labelRoCYear.Name = "labelRoCYear";
            this.labelRoCYear.Size = new System.Drawing.Size(1125, 81);
            this.labelRoCYear.TabIndex = 0;
            this.labelRoCYear.Text = "中華民國";
            this.labelRoCYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYear
            // 
            this.labelYear.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelYear.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelYear.Location = new System.Drawing.Point(1148, 9);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(190, 81);
            this.labelYear.TabIndex = 1;
            this.labelYear.Text = "2000";
            this.labelYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 99);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelRoCYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "TitleForm";
            this.Text = "年份標題";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelRoCYear;
        private System.Windows.Forms.Label labelYear;
    }
}