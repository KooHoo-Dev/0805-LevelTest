using System;
using System.Collections.Generic;
using System.Text;

namespace Csharpe_Basic.Study
{
    public class Simple_Number_Printer
    {
        public void Run()
        {
            RunPrefixSum();
            RunMultiplicationTable();
        }

        public void RunPrefixSum()
        {
            Console.WriteLine("\n--- 누적합 출력기 숫자를 입력하세요---");
            string input = Console.ReadLine();

            // number까지의 누적합을 계산하는 반복문 로직을 작성하십시오
            // ex) 10 입력시 55 출력
            int number = int.Parse(input);

            // 아래부터 로직 작성~

            int sum = 0;

            for (int i = 1; i <= number; ++i) sum += i;

            Console.WriteLine(sum);

        }

        public void RunMultiplicationTable()
        {
            Console.WriteLine("\n--- 구구단 출력기 0~9까지의 숫자를 입력하세요---");
            string input = Console.ReadLine();

            // number의 구구단을 출력하는 로직을 작성하세요.
            // 0이 입력될 경우 전체 구구단을 출력합니다. (한 단위의 구구단 출력을 함수로 만들면 편함)
            // 3입력시 아래 처럼 한줄 한줄 출력. 
            // 3 x 1 = 3
            // 3 x 2 = 6
            // .....
            // 3 x 9 = 27
            // {number} x {i} 인데, number == 0 경우만 다름
            int number = int.Parse(input);

            // 아래부터 로직 작성~

            if(number != 0)
            {
                PrintMultiplication(number);
                return;
            }

            for (int i = 1; i <= 9; ++i)
            {
                PrintMultiplication(i);
            }
        }

        public void PrintMultiplication(int targetNumber)
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{targetNumber} x {i} = {targetNumber * i}");
            }
        }
    }
}
