namespace lab23
{
    public partial class MForm : Form
    {
        public MForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            MessageBox.Show("HOLLA MY FRIEND! " + current.ToString(), "приветствие");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("оно тебе надо?", "закрытие", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void zadanie1_button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }
        private void zadanie1_button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }
        private void zadanie1_button3_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();

        }

    }
}
