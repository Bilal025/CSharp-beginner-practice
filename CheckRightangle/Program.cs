namespace CheckRightangle
{
    class Triangle
    {
       
        public bool calculatepythagorastheorem(double x, double y, double z)
        {
        //    double x = C ;
        //     double y = A ;
        //    double z = B

            if (x*x == y*y + z*z || y*y == x*x + z*z || z*z == x*x + y*y) //Pythagoras thearem
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input side 1 of triangle:" );
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input side 2 of triangle:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input side 3 of triangle:");
            double z = Convert.ToDouble(Console.ReadLine());

            var triangle = new Triangle();
            if (triangle.calculatepythagorastheorem(x, y, z))
            {
                Console.WriteLine("its a rightangled triangle");
            }
            else
            {
                Console.WriteLine("its not a rightangled triangle");
            }
         //   Console.ReadLine();
        }
    }
}