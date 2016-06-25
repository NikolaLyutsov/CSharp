namespace Problem_1._Shapes
{
    using System;

    public class Test
    {
        public static void Main()
        {
            var shapesList = new Shape[]
            {
                 new Triangle(3, 4),
                 new Rectangle(5,6),
                 new Square(4)
           };

            foreach (var shape in shapesList)
            {
                Console.WriteLine(shape.GetType().Name + " area is: " + shape.CalculateSurface());
            }
        }
    }
}