using System.Diagnostics.Contracts;
using System.Drawing;
using System.Windows.Forms;

namespace Calendar
{
    public partial class CompareForm : Form
    {
        private int year;
        private readonly bool today, catAsRabbitYear;
        private readonly int[] compareOffset, monthOffset;

        private Image drawCache;

        public CompareForm(int year, int[] compareOffset = null, bool today = false, bool catAsRabbitYear = false)
        {
            Contract.Requires(monthOffset == null || monthOffset.Length == CalendarDrawer.MONTH_COUNT);

            InitializeComponent();
            this.year = year;
            Text = Util.getYearTitle(year);

            this.today = today;
            this.catAsRabbitYear = catAsRabbitYear;

            this.compareOffset = compareOffset;
            monthOffset = new int[CalendarDrawer.MONTH_COUNT];
        }

        private void drawMonthOffset(Graphics graphic)
        {
            Font font = new Font(CalendarDrawer.FONT_NAME, 12, FontStyle.Bold);
            for (int i = 0; i < CalendarDrawer.MONTH_COUNT; ++i)
            {
                int offset = monthOffset[i] - compareOffset[i];
                string output = offset.ToString();
                if (offset > 0)
                {
                    output = $"+{offset}";
                }
                graphic.DrawString(output, font, getOffsetBrush(offset), 85, 48 + CalendarDrawer.MONTH_SPACE_Y * i, CalendarDrawer.centerStringFormat);
            }
        }

        public static Brush getOffsetBrush(int offset)
        {
            if (offset > 0)
            {
                return CalendarDrawer.greenBrush;
            }
            if (offset == 0)
            {
                return CalendarDrawer.blackBrush;
            }
            return CalendarDrawer.redBrush;
        }

        private void panelCalendar_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;
            if (drawCache == null)
            {
                CalendarDrawer.drawCalendar(graphic, year, monthOffset, today, catAsRabbitYear);
                if (compareOffset != null)
                {
                    drawMonthOffset(graphic);
                }
                drawCache = Util.saveControlImage(sender as Control);
                return;
            }
            graphic.DrawImage(drawCache, Point.Empty);
        }
    }
}