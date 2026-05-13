using System;
using System.Collections.Generic;
using System.Text;

namespace Csharpe_Basic.Study
{
    public class Variable_DataType
    {
        public void Variable()
        {
            // 변수(Variable)
            // : 변수는 데이터를 담는 그릇 or 상자이다
            // 컴파일러(컴퓨터)에게 변수를 만들라고 명령하고, 활용하고
            // 싶을때는 아래 3가지를 알려줘야 합니다.
            // - 공간, - 이름, - 값(데이터, 자료)

            // 1. 변수의 선언
            int myMoney;
            // : 컴퓨터는 메모리(RAM)에 myMoney라고 불리는 공간에 int 자료형을
            //  담을 수 있게 준비합니다.

            // 2. 변수의 할당
            myMoney = 10000;
            // : 컴퓨터는 전달받은 10000이라는 데이터를 myMoney라는 공간을 찾아서
            //  담아둡니다.

            // 3. 변수의 사용
            Console.WriteLine($"myMoney = {myMoney}");
            // : 컴퓨터는 콘솔프로그램에게 한줄 쓰라고 명령합니다. {myMoney} 부분을
            //  만나게 되면 해당 변수에 들어있는 데이터를 꺼내와서 대입해 줍니다.

            // 4. 변수의 초기화
            int myAge = 27;
            Console.WriteLine($"myAge = {myAge}");

            // 5. 변수의 재할당
            // 변수는 중괄호("{}")의 영역안에서는 재사용이 가능합니다.
            myMoney = 5000;
            myAge = 37;
            Console.WriteLine($"myMoney = {myMoney}");
            Console.WriteLine($"myAge = {myAge}");
        }

        public void DataType()
        {
            // 자료형(DataType)
            // 1. 정수형 = int(4바이트), byte(1바이트), (long, short)
            // => -1, 0, 1, 2, 3, 4, ...
            // => 자연수 + 음수

            // 2. 실수형(소수점) = float, (double, decimal)
            // => 3.14, 0.1, 0.33333, .....
            // => 소수점이 있는 수

            // 3. 논리형 = bool
            // => true, false (참, 거짓)

            // 4. 문자 = string, char
            // => "안녕하세요", 'A', "가"
            // => "문자" : 문자열 데이터의 표현
            // => '문자' : 문자 데이터의 표현


            int number =  5;
            float pie = 3.14f;  // 꼭 f를 넣어야함 (float 명시용)
            bool isTrue = false;
            string myName = "김재훈";
            char word = 'A';

            Console.WriteLine($"number = {number}, pie = {pie}," +
                $" isTrue = {isTrue}, myName = {myName}, word = {word}");
        }

        public void Operators()
        {
            Console.WriteLine("=======Operators========");
            // 연산자(Operators)
            // 컴퓨터가 연산을 수행하도록 지시하는 특별한 기호
            // 변수들을 사용해서 데이터를 처리하고 조작하는 데 사용됨

            // 산술 연산자
            // + (덧셈), - (뺄셈), * (곱셈),
            // / (나눗셈 "몫"), % (나눗셈 "나머지")

            int number = 100;
            Console.WriteLine(number + 50); // 덧셈 (150)
            Console.WriteLine(number - 25); // 뺄셈 (75)
            Console.WriteLine(number / 5); // 나눗셈 몫 (20)
            Console.WriteLine(number % 3); // 나눗셈 나머지 (1)

            // 할당(대입) 연산자
            number = 200;
            Console.WriteLine(number);

            number *= 10;
            Console.WriteLine(number);

            number -= 10;
            Console.WriteLine(number);
            // 비교 연산자
            // 논리 연산자

            // 증감(++,--)
            // 삼항은 나중에
        }
    }
}
