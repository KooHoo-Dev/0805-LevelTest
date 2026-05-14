using System;
using System.Collections.Generic;
using System.Text;

namespace Csharpe_Basic.Study
{
    public class Loop
    {
        public void For()
        {
            // 반복문 왜 쓸까요?
            // 1~10까지의 합을 출력하는 프로그램을 작성해봅시다

            int sum = 0;
            sum += 1;
            sum += 2;
            sum += 3;
            sum += 4;
            sum += 5;
            sum += 6;
            sum += 7;
            sum += 8;
            sum += 9;
            sum += 10;

            //int sum = 1 + 2 + 3 + 4 + 5....+10;

            // 1~10000까지의 합을 출력하는 프로그램을 작성해봅시다
            // for문을 이용하면 손쉽게 할 수 있습니다

            int sum2 = 0;
            for(int i = 1; i <= 10; i += 1)
            {
                sum2 += i;
                int number;
            }

            Console.WriteLine($"1~10000 까지의 합 : {sum2}");

            // 반복문이란?
            // - 특정 조건을 만족하는 동안, 정해진 코드 블록을
            // 반복적으로 실행하는 제어문 입니다.
            // 대표적으로 for문, while문 등이 있습니다 (do-while도 있음)

            // for문의 문법 구조

            // for(초기화식; 조건식; 증감식)
            // {
            //    반복적으로 실행할 코드;
            // }

            // 초기화식 : 반복문에서 사용할 변수를 선언 및 초기화
            // 조건식 : 반복문을 계속 실행할지 판단하는 식 (반복문의 중단을 담당)
            // 증감식 : 변수를 증가 혹은 감소 시키는 식

            // #실습
            // Q1. 1~100까지 짝수만 작은수부터 출력하는 프로그램을 작성 할 것

            for (int i = 1; i <= 100; ++i)
            {
                if (i % 2 == 0) Console.WriteLine($"{i}");
            }

            Console.WriteLine("=========================");
            // Q2. 1~100까지 홀수만 큰수부터 출력하는 프로그램을 작성 할 것
            for (int i = 100; i > 0; --i)
            {
                if (i % 2 == 1) Console.WriteLine($"{i}");
            }

            // Q3. -50 ~ 50까지의 총합을 출력하는 프로그램을 작성할 것 (답 = 0)
            int sum3 = 0;
            for(int i = -50; i <= 50; ++i)
            {
                sum3 += i;
            }
            Console.WriteLine("=========================");
            Console.WriteLine($"{sum3}");
        }

        public void While()
        {
            // While

            // While(조건식)
            // {
            //      반복적으로 실행할 코드
            // }

            // 반복문에서 자주 사용되는 키워드
            // break      : 지정된 반복문이나 코드 블록을 탈출하는데에 사용합니다
            // continue   : 실행중인 반복문을 한단계 건너 뜁니다 (탈출이 아님)

            bool isExit = false;
            while (isExit == false)
            {
                Console.WriteLine("while문이 실행중입니다.");
                string input = Console.ReadLine();

                
                if (input == "continue")
                {
                    Console.WriteLine("continue 통해 while문 반복을 건너뜁니다.");
                    continue;
                    Console.WriteLine("이 코드는 실행되 않습니다");
                }
                else if (input == "break")
                {
                    Console.WriteLine("break를 통해 while문을 탈출합니다.");
                    break;
                }
                else if (input == "exit")
                {
                    isExit = true;
                }
            }
        }

        public void Function()
        {
            // 프로그래밍에서의 함수
            // - 특정 작업 수행하는 재사용 가능한 코드의 묶음
            // - 컴퓨터에게 작업을 지시하는 명령어들의 집합
            // - 컴퓨터의 행동 단위 = 컴퓨터에게 일을 시키는 단위

            // 함수의 선언 구조
            // [접근제한자] [반환 자료형] 함수 이름 (매개변수1, 매개변수2 ...)
            // {
            //    함수 몸체 (로직)
            //    ex) int result = 3 * x + 1;
            //    
            //     return 반환값;
            //    ex) return result;
            // }
            // 새로운 자료형 : void
            // 반환값이 없는 함수는 void 자료형을 사용합니다.

            int funcAresult = FuncA(10);
            Console.WriteLine($"funcAresult : {funcAresult}");

            for(int i = 0; i < 10; ++i)
            {
                Console.WriteLine(FuncA(i));
            }

            int number = 3;

            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine($"Sum : {Sum(number, i)}");
                Console.WriteLine($"Multiply : {Multiply(number, i)}");
            }

            for (int i = 0; i < 1000; ++i)
            {
                PrintMessageA();
            }
        }

        public int FuncA(int x)
        {
            int result = 3 * x + 1;
            return result;
        }

        // Q1 : 두개의 매개변수(int a, int b)를 전달받아 두 변수의 합을 반환하는
        //     함수를 작성해보세요 (함수명 : Sum)

        public int Sum(int a, int b)
        {
            return a + b;
        }

        // Q2 : 두개의 매개변수(int a, int b)를 전달받아 두 변수의 곱을 반환하는
        //     함수를 작성해보세요 (함수명 : Multiply)

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public void PrintMessageA()
        {
            Console.WriteLine("===========");
            Console.WriteLine("아 함수는 너무 어렵다");
            Console.WriteLine("고등학교때 수학을 좀 해둘껄");
            Console.WriteLine("이게 무슨 소리인가");
        }
    }
}
