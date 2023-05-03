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
            int min = Convert.ToInt32(Min.Value);
            int max = Convert.ToInt32(Max.Value);
            int count = Convert.ToInt32(Count.Value);
            int[] numArray = new int[count];

            if (count == 0)
            {
                NumArray.Text = "생성 개수 누락";
            }
            else {
                for (int loop = 0; loop < count; loop++) {
                    numArray[loop] = rand.Next(min, max);
                }

                NumArray.Text = String.Join(", ", numArray);
            }

            
        }
    }
}