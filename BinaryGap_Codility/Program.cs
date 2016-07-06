using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap_Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            string binaryResult = GetBinaryRepresentaion(1041);
            var maxLenght = GetMaxLenght(binaryResult);
            Console.WriteLine(maxLenght);
            Console.ReadLine();
        }

        private static int GetMaxLenght(string binaryRepresentation)
        {
            
            var tmpArray = binaryRepresentation.Split('1');

            var tmpResult = from c in tmpArray
                            orderby c.Length
                            select c;


            return Convert.ToInt32(tmpResult.Last().Length);
        }
        private static string GetBinaryRepresentaion(int n)
        {
            StringBuilder result = new StringBuilder();
            int acum = n;

            while (acum > 0)
            {
                if (acum % 2 == 0)
                {
                    result.Append("0");
                }
                else
                {
                    result.Append("1");
                }
                acum = acum / 2;
            }


            return result.ToString();
        }
    }
}
