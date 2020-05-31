using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 숫자_맞추기_게임
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomnumber = random.Next(1, 101);
          
            Console.WriteLine("0 ~ 100까지의 숫자를 입력해주세요.");
            int picknumber = int.Parse(Console.ReadLine());

            while (randomnumber != picknumber)
            {
               if (randomnumber > picknumber)
                {
                    Console.WriteLine("더 큰 숫자입니다.");
                }
                
                if(randomnumber < picknumber)
                {
                    Console.WriteLine("더 작은 숫자입니다.");
                }
                
                Console.WriteLine("다시 한 번 입력해주세요.");
                picknumber = int.Parse(Console.ReadLine());

                if (randomnumber == picknumber)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
            } //p308 10 - 1 오오 잘하구있구만유!
        }
    }
}
