namespace laba33
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetStyle(this);
        }
        public void Navigate(Form formFrom, Form formTo)
        {
            formFrom.Hide();

            formTo.ShowDialog();

            formFrom.Show();

        }
        public void SetStyle(Control element)
        {
            foreach (Control control in element.Controls)
            {
                if (control is Button button)
                {
                    button.Cursor = Cursors.Hand;
                }
                SetStyle(control);
            }
        }

        private void ToNotesButton_Click(object sender, EventArgs e)
        {
            NoteForm form = new NoteForm();
            Navigate(this, form);
        }

        private void ToAuthButton_Click(object sender, EventArgs e)
        {
            AuthForm form = new AuthForm();
            Navigate(this, form);
        }

        private void ToDataAppend_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm();
            Navigate(this, form);
        }
    }
}
