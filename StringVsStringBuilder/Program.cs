using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            //Console.WriteLine(p1.bilder().ToString());
            Console.WriteLine(p1.builder2())
            Console.ReadKey()
        }

        public StringBuilder bilder()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 1; i < 10000; i++)
            {
                 builder.Append(i + " "); // burada her bir reqem ucun ayrica object yaratmiyacaq. 10000 reqemin hamisini 1 builder objectine yazacaq
            }
           return builder;
        }

        public string builder2()
        {
            string bilder=string.Empty;
            for (int i = 1; i < 10000; i++)
            {
                bilder += (i + " ");// burada ise her bir reqem ucun yeni object yaradacaq. yeni 10000 object. ancaq en sonda hamisi
                // son objectde yazilacaq "+=" oldugu ucun.. diger 9999 object lazimsiz yer tutacaq heap-da
            }
            return bilder;
        }
    }
}
