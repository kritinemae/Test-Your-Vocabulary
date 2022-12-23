namespace Test_Your_Vocabulary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void LoadForm(object Form)
        {
            if(this.MainPanel.Controls.Count > 0)
               this.MainPanel.Controls.RemoveAt(0);

            Form form = Form as Form;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;
            form.Show();
            
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            LoadForm(new EasyForm());
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            LoadForm(new HardForm());
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            LoadForm(new MediumForm());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}