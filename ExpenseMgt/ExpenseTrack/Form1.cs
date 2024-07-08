namespace ExpenseTrack
{
    public partial class Form1 : Form
    {
        ExpenseContext _exContext = new ExpenseContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

            var item = _exContext.LogingInfos.Select(s => new
            {
                username = s.Username as string,
                userpassword = s.Userpassword as string
            }).Where(w => w.username.ToUpper() == txtUserName.Text.ToUpper() && w.userpassword == txtPassword.Text.ToUpper()).FirstOrDefault();

            if (item != null)
            {
                this.Hide();
                AllLink allLink = new AllLink();
                allLink.ShowDialog();
            }
        }
    }
}