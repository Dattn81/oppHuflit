using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Color
    {
        private int Red;
        private int Green;
        private int Blue;
        private int Alpha;
        public int red
        {
            get { return this.Red; }
            set
            {
                this.Red = value;
                if((this.Red < 0) || (this.Red >255)) this.Red = 255;
            }
        }
        public int green
        {
            get { return this.Green; }
            set
            {
                this.Green = value;
                if ((this.Green < 0) || (this.Green > 255)) this.Green = 255;
            }
        }
        public int blue
        {
            get { return this.Blue; }
            set
            {
                this.Blue = value;
                if ((this.Blue < 0) || (this.Blue> 255)) this.Blue = 255;
            }
        }
        public int alpha
        {
            get { return this.Alpha; }
            set
            {
                this.Alpha = value;
                if ((this.Alpha < 0) || (this.Alpha> 255)) this.Alpha = 255;
            }
        }
        public Color()
        {
            this.red = 255;
            this.green = 255;
            this.blue = 255;
            this.alpha = 255;
        }
        public Color(int red,int green, int blue, int alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        public Color(Color c)
        {
            this.red = c.red;
            this.green = c.green;
            this.blue = c.blue;
            this.alpha = c.alpha;
        }
        public double grayscale()
        {
            return (this.red + this.green + this.blue) / 3;
        }
    }
}
