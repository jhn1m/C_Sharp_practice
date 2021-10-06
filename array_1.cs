using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static private void array()
        {
            while(true){
                Console.WriteLine("배열크기 지정");
                int array_length = Convert.ToInt32(Console.ReadLine());
                string[] array = new string[array_length];

                Console.WriteLine("몇 번 입력받습니까?");
                int length = Convert.ToInt32(Console.ReadLine());

                if (array_length < length)
                {
                    Console.WriteLine("배열값보다 크게 입력받을 수 없습니다.");
                }
                else{
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine("저장할 문자는?");
                        array[i] = Console.ReadLine();
                        Console.WriteLine(i+1 + "번째 입력값은 " + array[i]);
                    }
                    break;
                }
            }
        }

        static void Main(string[] args)
        {
            array();
        }
    }

}
