using System.Windows.Forms;

namespace Calendar
{
    public partial class TitleForm : Form
    {
        public TitleForm(int year)
        {
            InitializeComponent();
            labelYear.Text = year.ToString();
            labelRoCYear.Text = Util.getRoCYear(year);
        }
    }
}