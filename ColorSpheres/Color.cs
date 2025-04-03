namespace ColorSpheres
{
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color(int red, int green, int blue, int alpha = 255)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
         public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

         public int GetRed()
         {
                return red;
         }
        
        public int GetGreen()
        {
                return green;
        }

        public int GetBlue()
        {
                return blue;
        }

        public int GetAlpha()
        {
                return alpha;
        }

        public int GetGray()
        {
                return (red + green + blue) / 3;
        }
    }
}