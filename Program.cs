using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breaKString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter String :");
            string s = Console.ReadLine();
            Console.Write("Break String into __________ Substring :");
            int a = Convert.ToInt32(Console.ReadLine());
            //lenth of substrings

            int[] array1 = new int[a + 1];

            for (int i = 0; i < a; i++)
            {
                Console.Write("Break_index at {0} position:", i);
                array1[i] = Convert.ToInt32(Console.ReadLine());

                  if (array1[i] >= s.Length + 1 &&i<=0 )
                    {
                        Console.Write("break index should be less  than or equal to {0} \n", s.Length);
                        --i;

                    }

                if (i > 0)
                {
                    if (array1[i - 1] >= array1[i] )
                    {
                        Console.Write("break index should be greater than {0} \n", array1[i - 1]);
                        --i;
                    }
                    else if (array1[i] >= s.Length + 1 )
                    {
                        Console.Write("break index should be less  than or equal to {0} \n", s.Length);
                        --i;
    }}}

            if (array1[a - 1] < s.Length)
            {
                array1[a] = s.Length;

            }

            if (array1[a-1] == s.Length)
            {
                array1[a] = -1;


            }

            string[] array = StringBreak(array1, s);
           
            foreach (string value in array)
            {
                Console.WriteLine(value);
                Console.Write(",");



            }
        }


        static string[] StringBreak(int[] Array, string s)
        {

            string temp = null;
            char traverse;
            string[] stringarray;
            if (Array[Array.Length - 1] != -1)
            {
                 stringarray = new string[Array.Length];
            }
            else
            {
                 stringarray = new string[Array.Length-1];

            }
            int break_index, start_index = 0;

            for (int i = 0; i < stringarray.Length ; i++)
            {

                break_index = Array[i];

                if (i > 0)
                {
                    start_index = Array[i - 1];
                }
                for (int j = start_index; j < break_index; j++)
                {
                    traverse = s[j];

                    temp = temp + traverse;
                }
                stringarray[i] = temp;
                temp = null;

            }
            return stringarray;
        }
    }
}