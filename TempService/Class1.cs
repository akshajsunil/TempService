namespace TempService
{
    public class temp
    {
        public double CFT(double t)
        {
            return (t * 9 / 5) +32;
        }
        public double FTD(double t)
        {
            return (t-32)*5/9;
        }


    }
}