namespace ColorSpheres
{
    public class Sphere
    {
        private int radius;
        private Color color;
        private int throwCount;

        public Sphere(int radius, Color color)
        {
            this.radius = radius;
            this.color = color;
            this.throwCount = 0;
        }

        public void Pop()
        {
            this.radius = 0;
        }

        public void Throw()
        {
            if (this.radius > 0)
            {
                this.throwCount++;
            }
        }

        public int GetTimesThrown()
        {
            return this.throwCount;
        }
    }
}