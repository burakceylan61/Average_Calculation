namespace Average_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double not_1, note_2, not_3;
            double Average;
                
            not_1 = Convert.ToDouble(textBox1.Text);
            note_2 = Convert.ToDouble(textBox2.Text);
            not_3 = Convert.ToDouble(textBox3.Text);

            Average = (not_1 + note_2 + not_3) / 3;
            textBox4.Text = Convert.ToString(Average);
        
        
        
        
        }
    }
}