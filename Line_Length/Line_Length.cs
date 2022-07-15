namespace Line_Comparision_App
{
    public class Line_Length
    {
        public static void LineLength(int x1,int x2,int y1,int y2)
        {
            double length;
            length = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
            Console.WriteLine("Length of Line = "+Math.Sqrt(length));

        }
    }
}