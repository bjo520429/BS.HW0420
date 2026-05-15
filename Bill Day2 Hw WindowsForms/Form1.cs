using System.Globalization;

namespace Bill_Day2_Hw_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sat = 52;                                               //累計週六的次數
            int sun = 52;                                               //累計週日的次數
            int input = int.Parse(textBox1.Text);                       //取得用戶查詢年分
            DateTime firstDay = new DateTime(input, 01, 01);
            if (DateTime.IsLeapYear(input))                             //閏年?
            {
                if (firstDay.DayOfWeek == DayOfWeek.Friday)
                {
                    sat++;
                }
                else if (firstDay.DayOfWeek == DayOfWeek.Saturday)
                {
                    sat++;
                    sun++;
                }
                else if (firstDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    sun++;
                }
            }
            else
            {
                if (firstDay.DayOfWeek == DayOfWeek.Saturday)
                {
                    sat++;
                }
                else if (firstDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    sun++;
                }
            }
            label1.Text = $"星期六有 {sat} 天\n星期天有 {sun} 天\n(非迴圈)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sat = 0;
            int sun = 0;
            int input = int.Parse(textBox1.Text);
            DateTime baseDate = new DateTime(input, 01, 01);
            while (baseDate.DayOfWeek != DayOfWeek.Saturday)            //算週六
            {
                baseDate = baseDate.AddDays(1);
            }
            while (baseDate.Year == input)
            {
                baseDate = baseDate.AddDays(7);
                sat++;
            }
            baseDate = new DateTime(input, 01, 01);                     //算週日
            while (baseDate.DayOfWeek != DayOfWeek.Sunday)
            {
                baseDate = baseDate.AddDays(1);
            }
            while (baseDate.Year == input)
            {
                baseDate = baseDate.AddDays(7);
                sun++;
            }
            label1.Text = $"星期六有 {sat} 天\n星期天有 {sun} 天\n(迴圈)";

        }

        static int GetWeekCount()
        {
            int daysOfYear = 365;
            int daysOfWeek = 7;
            int weeksOfYear = daysOfYear / daysOfWeek;

            return weeksOfYear;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int weeks = GetWeekCount();
            int input = int.Parse(textBox1.Text);
            DateTime firsrDate = new DateTime(input, 1, 1);
            DateTime lastDate = new DateTime(input, 12, 31);
            int sat, sun;

            if(firsrDate.DayOfWeek == DayOfWeek.Saturday || lastDate.DayOfWeek == DayOfWeek.Saturday)
            {
                sat = weeks + 1;
            }
            else { sat = weeks; }
                
            if (firsrDate.DayOfWeek == DayOfWeek.Sunday || lastDate.DayOfWeek == DayOfWeek.Sunday)
            {
                sun = weeks + 1;
            }
            else { sun = weeks; }

            label1.Text = $"星期六有 {sat} 天\n星期天有 {sun} 天\n(不分閏年)";
        }
    }
}
