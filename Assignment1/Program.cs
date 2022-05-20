using System;



namespace Assignment1
{
   

    class Program
    {
        public void RaisedTo(double x , double y)
        {

            Console.WriteLine(  Math.Pow(x, y) );
            
        }
        public void Fact(double x)
        {
            double z = 1;
            for(int i =1;i<=x; i++)
            {
                 z = x *(double)i;
            }
            Console.WriteLine(z);
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            a.RaisedTo(2.0, 3.0);
            a.Fact(2);
           

        }
    }
}
