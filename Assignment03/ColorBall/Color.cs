using System;
namespace ColorBall
{
    public class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }

        public Color(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

        public int GetGrayscale()
        {
            return (Red + Green + Blue) / 3;
        }
    }
}

