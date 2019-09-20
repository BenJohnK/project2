using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleapp
{
    class TestTemperature
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            DividebyZero Sample = new DividebyZero();
            try
            {
                Sample.show();
                temp.showTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0} -- {1}", e.Message, e.Source);
            }
            Console.ReadKey();
        }
    }
}

public class TempIsZeroException : Exception
{
    public TempIsZeroException(string message)
        : base(message)
    {
    }
}

public class Temperature
{
    int temperature = 0;
    public void showTemp()
    {
        if (temperature == 0)
        {
            throw (new TempIsZeroException("Zero Temperature found"));
        }
        else
        {
            Console.WriteLine("Temperature: {0}", temperature);
        }
    }
}