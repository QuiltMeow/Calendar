namespace Calendar
{
    partial class YearForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YearForm));
            this.labelAD = new System.Windows.Forms.Label();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnThisYear = new System.Windows.Forms.Button();
            this.labelRoCYear = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAD
            // 
            this.labelAD.AutoSize = true;
            this.labelAD.Location = new System.Drawing.Point(25, 25);
            this.labelAD.Name = "labelAD";
            this.labelAD.Size = new System.Drawing.Size(29, 12);
            this.labelAD.TabIndex = 0;
            this.labelAD.Text = "西元";
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(70, 23);
            this.numYear.Maximum = new decimal(new int[] {
            9998,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(120, 22);
            this.numYear.TabIndex = 1;
            this.numYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numYear.ValueChanged += new System.EventHandler(this.numYear_ValueChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(245, 20);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "確定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnThisYear
            // 
            this.btnThisYear.Location = new System.Drawing.Point(245, 60);
            this.btnThisYear.Name = "btnThisYear";
            this.btnThisYear.Size = new System.Drawing.Size(75, 23);
            this.btnThisYear.TabIndex = 5;
            this.btnThisYear.Text = "今年";
            this.btnThisYear.Click += new System.EventHandler(this.btnThisYear_Click);
            // 
            // labelRoCYear
            // 
            this.labelRoCYear.AutoSize = true;
            this.labelRoCYear.Location = new System.Drawing.Point(25, 65);
            this.labelRoCYear.Name = "labelRoCYear";
            this.labelRoCYear.Size = new System.Drawing.Size(53, 12);
            this.labelRoCYear.TabIndex = 3;
            this.labelRoCYear.Text = "中華民國";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(205, 25);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(17, 12);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "年";
            // 
            // YearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 101);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelRoCYear);
            this.Controls.Add(this.btnThisYear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.labelAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "YearForm";
            this.Text = "年份選擇";
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAD;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnThisYear;
        private System.Windows.Forms.Label labelRoCYear;
        private System.Windows.Forms.Label labelYear;
    }
}