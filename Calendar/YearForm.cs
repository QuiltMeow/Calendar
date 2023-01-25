using System;
using System.Windows.Forms;

namespace Calendar
{
    public partial class YearForm : Form
    {
        public int year
        {
            get;
            private set;
        }

        public YearForm()
        {
            InitializeComponent();
            updateThisYear();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            year = Convert.ToInt32(numYear.Value);
            DialogResult = DialogResult.OK;
        }

        private void numYear_ValueChanged(object sender, EventArgs e)
        {
            labelRoCYear.Text = Util.getRoCYear(Convert.ToInt32(numYear.Value));
        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            updateThisYear();
        }

        private void updateThisYear()
        {
            try
            {
                numYear.Value = Program.now.Year;
            }
            catch
            {
                const int DEFAULT_YEAR = 2000;
                numYear.Value = DEFAULT_YEAR;
            }
        }
    }
}