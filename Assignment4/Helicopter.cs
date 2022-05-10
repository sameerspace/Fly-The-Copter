using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Helicopter :PictureBox
    {
       public Helicopter()
       {
            this.Location = new Point(153,114);
            this.Image = new Bitmap("heli.png");
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Size = new Size(125,62);
       }
    }
}
