namespace Line_Comparision_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2;
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("Enter Coordinates x1 and y1 of line1");
            var line1 = Console.ReadLine();
            var line1_coordinates = line1.Split(' ');
            x1 = Convert.ToInt32(line1_coordinates[0]);
            y1 = Convert.ToInt32(line1_coordinates[1]);
            //Console.WriteLine("Coordinates of line1 are {0} and {1}", x1, y1);
     
            Console.WriteLine("Enter Coordinates x2 and y2 of line2");
            var line2 = Console.ReadLine();
            var line2_coordinates = line2.Split(' ');
            x2 = Convert.ToInt32(line2_coordinates[0]);
            y2 = Convert.ToInt32(line2_coordinates[1]);
            //Console.WriteLine("Coordinates of line2 are {0} and {1}", x2, y2);

            Line_Length.LineLength(x1,y1,x2,y2);   //calling class function






        }
    }
}