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
            {
                rtxtbxHistory.Text += $"{x.Year} year, {x.Month} month\r";
            }
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
            int remainderMonth = 0;
            // 1 year 10 months
            // 1 year 1 months
            // 1 year 4 month
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
            rtxtbxHistory.Text = "";
        }
    }
}
