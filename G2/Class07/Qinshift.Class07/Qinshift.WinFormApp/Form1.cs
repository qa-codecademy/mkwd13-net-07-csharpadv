namespace Qinshift.WinFormApp
{
    public partial class Form1 : Form
    {
        public int Counter { get; set; }
        public Form1()
        {
            Counter = 0;
            InitializeComponent();
        }

        private void WhenButtonClickedBy1(object sender, EventArgs e)
        {
            Counter += 1;
            lblNumberView.Text = $"I've been clicked {Counter} times!";
            if(Counter >= 10)
            {
                btnClick.Click -= WhenButtonClickedBy1;
                btnClick.Click += WhenButtonClickedBy2;
            }
        }

        public void WhenButtonClickedBy2(object sender, EventArgs e)
        {
            Counter += 2;
            lblNumberView.Text = $"I've been clicked {Counter} times!";

            if(Counter >= 30)
            {
                btnClick.Enabled = false;
            }
        }

        public void Something(object source, EventArgs args)
        {
            lblNumberView.Text = "Hey this is the mouse event!";
        }

        public void SomethingElse(object source, EventArgs args)
        {
            lblNumberView.Text = "";
        }
    }
}
