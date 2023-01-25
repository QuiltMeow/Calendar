using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calendar
{
    public partial class MainForm : Form
    {
        private int year;
        private readonly int[] monthOffset;

        private Image drawCache;

        public MainForm()
        {
            InitializeComponent();
            year = Program.now.Year;
            updateTitle();
            monthOffset = new int[CalendarDrawer.MONTH_COUNT];
        }

        private void updateTitle()
        {
            Text = Util.getYearTitle(year);
        }

        private void tsmiChangeYear_Click(object sender, EventArgs e)
        {
            using (YearForm yearForm = new YearForm())
            {
                if (yearForm.ShowDialog() == DialogResult.OK)
                {
                    year = yearForm.year;
                    updateTitle();
                    refreshCalendar();
                }
            }
        }

        private void tsmiCompareYear_Click(object sender, EventArgs e)
        {
            using (YearForm yearForm = new YearForm())
            {
                if (yearForm.ShowDialog() == DialogResult.OK)
                {
                    using (Form compareForm = new CompareForm(yearForm.year, monthOffset, tsmiToday.Checked, tsmiCatAsRabbitYear.Checked))
                    {
                        compareForm.ShowDialog();
                    }
                }
            }
        }

        private void panelCalendar_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;
            if (drawCache == null)
            {
                CalendarDrawer.drawCalendar(graphic, year, monthOffset, tsmiToday.Checked, tsmiCatAsRabbitYear.Checked);
                drawCache = Util.saveControlImage(sender as Control);
                return;
            }
            graphic.DrawImage(drawCache, Point.Empty);
        }

        private void tsmiYearTitle_Click(object sender, EventArgs e)
        {
            using (TitleForm titleForm = new TitleForm(year))
            {
                titleForm.ShowDialog();
            }
        }

        private void refreshCalendar()
        {
            drawCache = null;
            panelCalendar.Refresh();
        }

        private void tsmiToday_Click(object sender, EventArgs e)
        {
            refreshCalendar();
        }

        private void tsmiCatAsRabbitYear_Click(object sender, EventArgs e)
        {
            refreshCalendar();
        }
    }
}