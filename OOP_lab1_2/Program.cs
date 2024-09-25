namespace OOP_lab1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TCircle circle1 = new TCircle();
            circle1.Input();
            circle1.Output();
            Console.WriteLine("Area: " + circle1.GetArea);
            Console.WriteLine("Circuit: " + circle1.GetCircuit);

            TCircle circle2 = new TCircle();
            circle2.Input();
            circle2.Output();
            Console.WriteLine("Area: " + circle2.GetArea);
            Console.WriteLine("Circuit: " + circle2.GetCircuit);

            Console.WriteLine("Compare circles: ");
            Console.WriteLine(circle1.Compare(circle2));

            TCircle sumOfCircle = circle1 + circle2;
            Console.WriteLine("Sum of circle: ");
            sumOfCircle.Output();

            Console.WriteLine("Cylinder: ");
            TCylinder cylinder = new TCylinder();

            cylinder.Input();
            cylinder.Output();

            Console.WriteLine("Volume: " + cylinder.GetVolume);
        }
    }
}
