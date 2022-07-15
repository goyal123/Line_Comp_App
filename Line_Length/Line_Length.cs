namespace Line_Comparision_App
{
    public class Line_Length
    {
        public static double LineLength(int x1,int y1,int x2,int y2)
        {
            double length;
            length = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            //Console.WriteLine("Length of Line = "+Math.Sqrt(length));
            return Math.Sqrt(length);

        }
    }
}