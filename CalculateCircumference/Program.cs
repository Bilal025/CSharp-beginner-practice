namespace CalculateCircumference
{
    class Circle
    {
        //Calculate circumference
        public double circumference(Double radius)
        {
            Double c = 2 * 3.14 * radius; //do somethigs
            return c; //return the value
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle");
            double r = Convert.ToDouble(Console.ReadLine());

            var circle = new Circle(); // initialize
            double c = circle.circumference(r);

            Console.WriteLine("circumference is {0}", c);
            Console.ReadLine();

        }
    }
}

