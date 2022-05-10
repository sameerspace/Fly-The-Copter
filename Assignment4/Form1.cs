namespace Assignment4
{
    public partial class HomeForm : Form
    {
        Helicopter copter;
        
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point old = copter.Location;
                copter.Location = new Point(old.X,old.Y-10);
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            copter = new Helicopter();
            this.Controls.Add(copter);  
        }
    }
}