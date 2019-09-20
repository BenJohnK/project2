using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleapp
{
    class DividebyZero
    {
        public int abc;
        private int[] j = new int[] { 1, 2 };
        private int[] g = new int[2];
        private int a = 2, b = 0, c;

        public void show()
        {
            try
            {
                c = a / b;
                c = g[5];
            }
            catch (IndexOutOfRangeException w)
            {
                Console.WriteLine("index - " + w.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(1+"catch" + e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("END");
            }
        }
    }
}
