namespace YearsOfExperienceCalculator
{
    public partial class Form1 : Form
    {
        public List<Model> _exp = new();
        public int _year = 0;
        public int _month = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numboxYear.Select();
            btnTotal.Enabled = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            _year = (int)numboxYear.Value;
            _month = (int)numboxMonth.Value;

            _exp.Add(new Model
            {
                Month = _month,
                Year = _year,
            });
            PopulateRichTextBox();
        }
        private void PopulateRichTextBox()
        {
            rtxtbxHistory.Text = "";
            foreach (var x in _exp)
                rtxtbxHistory.Text += $"{x.Year} year, {x.Month} month\r";

            btnTotal.Enabled = _exp.Any();
        }
        private int Subtract(int a, int b)
        {
            int res = 0;
            if (a >= b)
                res = a - b;
            else
                res = b - a;
            return res;
        }
        private void btnTotal_Click(object sender, EventArgs e)
        {
            int total = 0;
            int totalMonth = 0;

            for (int x = 0; x < _exp.Count(); x++)
            {
                totalMonth += _exp[x].Month;
                total += _exp[x].Year;
            }

            while (totalMonth >= 12)
            {
                total++;
                totalMonth = Subtract(totalMonth, 12);
            }

            lblTotal.Text = $"{total} year{(total > 1 ? "s" : "")}, {totalMonth} month{(totalMonth > 1 ? "s" : "")} of experience";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _exp = new();
            numboxMonth.Value = 0;
            numboxYear.Value = 0;
            PopulateRichTextBox();
        }

        private void numboxYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numboxMonth_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void numboxMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            int val = (int)numboxMonth.Value;
            if (val > 12)
                numboxMonth.Value = 0;
        }
    }
}
