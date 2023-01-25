namespace Calendar
{
    partial class CompareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompareForm));
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelCalendar
            // 
            this.panelCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCalendar.Location = new System.Drawing.Point(0, 0);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(1884, 983);
            this.panelCalendar.TabIndex = 0;
            this.panelCalendar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCalendar_Paint);
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 983);
            this.Controls.Add(this.panelCalendar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "CompareForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCalendar;
    }
}