using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 가위___바위___보__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------가위 ! 바위 ! 보!-------------------+");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("|----------|1 = 가위 | 2 = 바위 | 3 = 보 |-------------|");
            Console.WriteLine("|                                                      |");
            Console.WriteLine("+-------------------VS Super ComPuTer------------------+");

            Random random = new Random();

            Console.WriteLine("가위 바위 보 !");
            Console.WriteLine("정한 것을 내주세요!");

            int computerNumber = random.Next(1, 4);
            int PersonNumber = int.Parse(Console.ReadLine());

            while (PersonNumber != 1 && PersonNumber != 2 && PersonNumber != 3)
            {
                Console.WriteLine("가위, 바위, 보 이외의 것을 내면 혼나요 !");
                Console.WriteLine("다시 한번 내주세요!");
                PersonNumber = int.Parse(Console.ReadLine());

                if (PersonNumber == 1 || PersonNumber == 2 || PersonNumber == 3)
                {
                    break;
                }
            }

            while (PersonNumber == computerNumber)
            {
                Console.WriteLine("비겼습니다!");
                Console.WriteLine("다시 한 번, 가위 ! 바위 ! 보 !");
                computerNumber = random.Next(1, 4);
                PersonNumber = int.Parse(Console.ReadLine());

                if(computerNumber != PersonNumber)
                {
                    break;
                }
            }

            if(computerNumber == 1)
            {
                if (PersonNumber == 2) 
                {
                    Console.WriteLine("이겼습니다!");
                }
                if (PersonNumber == 3)
                {
                    Console.WriteLine("졌습니다!");
                }
            }

            if (computerNumber == 2)
            {
                if (PersonNumber == 3)
                {
                    Console.WriteLine("이겼습니다!");
                }
                if (PersonNumber == 1)
                {
                    Console.WriteLine("졌습니다!");
                }
            }

            if (computerNumber == 3)
            {
                if (PersonNumber == 1)
                {
                    Console.WriteLine("이겼습니다!");
                }
                if (PersonNumber == 2)
                {
                    Console.WriteLine("졌습니다!");
                }
            }
        }
    }
}
