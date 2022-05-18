namespace Assignment4
{
    public partial class HomeForm : Form
    {
        Helicopter copter;
        List<int> wallHeights = new List<int>() { 100,110,120,130,150,140,120,115,110,100,70,90,120,150,160,180,140,150,110,125,122,135,169,150};

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point old = copter.Location;
                copter.Location = new Point(old.X,old.Y-5);
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            copter = new Helicopter();
            this.Controls.Add(copter);
            timer1.Enabled = true;
            foreach(int height in wallHeights)
            {
                Panel panel = new Panel();
                panel.Size = new Size(100, height);
                panel.BackColor = Color.DarkGreen;
                panel.Location = new Point(i*100,this.Height-height-50);
                this.Controls.Add(panel);

                Panel topPanel = new Panel();
                topPanel.Size = new Size(100,height);   
                topPanel.BackColor= Color.DarkGreen;
                topPanel.Location = new Point(i * 100, 0);
                this.Controls.Add(topPanel);
            
                i++;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point old = copter.Location;
            copter.Location = new Point(old.X, old.Y + 10);
            foreach(Control control in this.Controls)
            {
                if(control is Panel)
                {
                    
                    
                    Panel? p = control as Panel;
                    Point loc = p.Location;
                    loc.X -= 10;
                    p.Location = loc;

                    if(p.Location.X < -100)
                    {
                        this.Controls.Remove(p);
                    }
                    

                }

            }
            CheckCollision();

        }

        private void CheckCollision()
        {
            foreach(Control control in this.Controls)
            {
                if(control is Panel)
                {
                    if (copter.Bounds.IntersectsWith(control.Bounds))
                    {
                        timer1.Stop();
                        MessageBox.Show("GameOver");
                    }
                }
            }
        }
        private void HomeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point old = copter.Location;
                copter.Location = new Point(old.X, old.Y - 5);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}