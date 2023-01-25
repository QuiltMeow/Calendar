namespace Calendar
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiChangeYear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompareYear = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.tsmiYearTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToday = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCatAsRabbitYear = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangeYear,
            this.tsmiCompareYear,
            this.tsmiYearTitle,
            this.tsmiToday,
            this.tsmiCatAsRabbitYear});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(181, 136);
            // 
            // tsmiChangeYear
            // 
            this.tsmiChangeYear.Name = "tsmiChangeYear";
            this.tsmiChangeYear.Size = new System.Drawing.Size(180, 22);
            this.tsmiChangeYear.Text = "變更年份";
            this.tsmiChangeYear.Click += new System.EventHandler(this.tsmiChangeYear_Click);
            // 
            // tsmiCompareYear
            // 
            this.tsmiCompareYear.Name = "tsmiCompareYear";
            this.tsmiCompareYear.Size = new System.Drawing.Size(180, 22);
            this.tsmiCompareYear.Text = "比較年份";
            this.tsmiCompareYear.Click += new System.EventHandler(this.tsmiCompareYear_Click);
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
            // tsmiYearTitle
            // 
            this.tsmiYearTitle.Name = "tsmiYearTitle";
            this.tsmiYearTitle.Size = new System.Drawing.Size(180, 22);
            this.tsmiYearTitle.Text = "檢視年份標題";
            this.tsmiYearTitle.Click += new System.EventHandler(this.tsmiYearTitle_Click);
            // 
            // tsmiToday
            // 
            this.tsmiToday.Checked = true;
            this.tsmiToday.CheckOnClick = true;
            this.tsmiToday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiToday.Name = "tsmiToday";
            this.tsmiToday.Size = new System.Drawing.Size(180, 22);
            this.tsmiToday.Text = "標記今日";
            this.tsmiToday.Click += new System.EventHandler(this.tsmiToday_Click);
            // 
            // tsmiCatAsRabbitYear
            // 
            this.tsmiCatAsRabbitYear.CheckOnClick = true;
            this.tsmiCatAsRabbitYear.Name = "tsmiCatAsRabbitYear";
            this.tsmiCatAsRabbitYear.Size = new System.Drawing.Size(180, 22);
            this.tsmiCatAsRabbitYear.Text = "兔 / 貓年";
            this.tsmiCatAsRabbitYear.Click += new System.EventHandler(this.tsmiCatAsRabbitYear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 983);
            this.ContextMenuStrip = this.cmsMenu;
            this.Controls.Add(this.panelCalendar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeYear;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompareYear;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.ToolStripMenuItem tsmiYearTitle;
        private System.Windows.Forms.ToolStripMenuItem tsmiToday;
        private System.Windows.Forms.ToolStripMenuItem tsmiCatAsRabbitYear;
    }
}

