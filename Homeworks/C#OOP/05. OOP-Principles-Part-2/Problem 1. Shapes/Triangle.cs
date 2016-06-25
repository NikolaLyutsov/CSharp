namespace Problem_1._Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(height, width)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
