namespace LottoNumberSpawner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int[] numArray = new int[6];

            if (Lotto.Checked == true)
            {
                for (int loop = 0; loop < 6; loop++) {
                    numArray[loop] = rand.Next(1, 45);
                }
                NumArray.Text = String.Join(", ", numArray);
            }
            else if (Yeon.Checked == true)
            {
                for (int loop = 0; loop < 6; loop++)
                {
                    numArray[loop] = rand.Next(0, 9);
                }
                NumArray.Text = String.Join(", ", numArray);
            }
            else {
                NumArray.Text = "복권 종류 미선택";
            }
        }
    }
}