namespace Line_Comparision_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2,x3,x4,y3,y4;
            double length_line1, length_line2;

            Console.WriteLine("Welcome to Line Comparison Computation Program");

            Console.WriteLine("Enter Coordinates x1,y1 and x2,y2 of line1");
            var line1 = Console.ReadLine();
            var line1_coordinates = line1.Split(' ');
            x1 = Convert.ToInt32(line1_coordinates[0]);
            y1 = Convert.ToInt32(line1_coordinates[1]);
            x2 = Convert.ToInt32(line1_coordinates[2]);
            y2 = Convert.ToInt32(line1_coordinates[3]);

            Console.WriteLine("Enter Coordinates x3,y3 and x4,y4 of line2");
            var line2 = Console.ReadLine();
            var line2_coordinates = line2.Split(' ');
            x3 = Convert.ToInt32(line2_coordinates[0]);
            y3 = Convert.ToInt32(line2_coordinates[1]);
            x4 = Convert.ToInt32(line2_coordinates[2]);
            y4 = Convert.ToInt32(line2_coordinates[3]);

            length_line1 = Line_Length.LineLength(x1,y1,x2,y2);
            length_line2 = Line_Length.LineLength(x3, y3, x4, y4);
            

            //comparing using operators
            if (length_line1 == length_line2)
                Console.WriteLine("Both Lines are Equal");
            else if(length_line1 > length_line2)
                Console.WriteLine("Line1 is grater than Line2");
            else
                Console.WriteLine("Line2 is greater than Line1");

            //comparing using compareTo method in C#
            int status = length_line1.CompareTo(length_line2);
            if (status > 0)
                Console.WriteLine("{0} is greater than {1}",length_line1,length_line2);
            else if(status < 0)
                Console.WriteLine("{1} is greater than {0}", length_line2, length_line1);
            else
                Console.WriteLine("{0} is equal to {1}", length_line1, length_line2);

            if (length_line1.Equals(length_line2))
                Console.WriteLine("Length of both lines are Equal");
            else
                Console.WriteLine("Not Equal Lines");

        }
    }
}
