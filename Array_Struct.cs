using System;
using System.Collections.Generic;
using System.Text;

namespace Csharpe_Basic.Study
{
    public class Array_Struct
    {
        public void Array()
        {
            // 배열(Array)
            // - 자료 구조중에 하나로, 같은 종류의 데이터
            // 여러개를 하나의 묶으로 관리하기 위한 변수입니다.
            // 모든 언어에서 가장 기본이 되는 자료구조

            // 선언, 할당, 초기화

            // 1. 배열의 선언
            int[] array; // => int형 묶음인 array 변수를 준비해줘

            // 2. 배열의 할당
            array = new int[3]; // => int형 데이터 3개를 보관할 수 있는 공간을 만들어줘

            // new 키워드는 동적할당을 요청하는 키워드로
            // 컴퓨터는 new 키워드를 만나게 되면 메모리에 새로운 공간을 마련합니다.

            // 3. 배열의 초기화
            int[] numberArray = new int[3];

            // 4. 배열의 활용
            // 인덱스를 활용한 직접 대입
            numberArray[0] = 0;
            numberArray[1] = 1;
            numberArray[2] = 2;

            Console.WriteLine($"numberArray[0] = {numberArray[0]}");
            Console.WriteLine($"numberArray[1] = {numberArray[1]}");
            Console.WriteLine($"numberArray[2] = {numberArray[2]}");

            // 반복문과 함께 활용
            for (int i = 0; i < numberArray.Length; ++i)
            {
                numberArray[i] += 10;
                Console.WriteLine($"numberArray[{i}] = {numberArray[i]}");
            }

            // Q1. numberArray 모든 요소에 -1을 곱해서 재할당 하고
            // 모든 요소를출력하세요.

            for(int i = 0; i < numberArray.Length; ++i )
            {
                numberArray[i] *= -1;
                Console.WriteLine($"numberArray[{i}] = {numberArray[i]}");
            }

            // Q2. numberArray 모든 요소의 총합을 출력하세요
            int sum = 0;
            for (int i = 0; i < numberArray.Length; ++i)
            {
                sum += numberArray[i];
            }

            Console.WriteLine($"numberArray의 총합은 {sum}");

            // # 배열의 활용법
            // 1. 선언과 동시에 특정 값으로 초기화 (바로 대입)
            int[] numbers = new int[] { 10,20,30,40,50 };

            for (int i = 0; i < numbers.Length; ++i)
            {
                Console.WriteLine($"number[{i}] = {numbers[i]}");
            }

            // 2. new 키워드 생략 (더욱 간결한 표현)
            string[] names = { "Alice", "Bob", "Charlie" };
            Console.WriteLine($"names[0] = {names[0]}");
            Console.WriteLine($"names[1] = {names[1]}");
            Console.WriteLine($"names[2] = {names[2]}");

            // 3. 선형 탐색 (가장 간단한 탐색 방법)
            int[] examScores = { 11, 22, 73, 94, 82, 26, 55, 98 };

            // 3.1 80점 이상인 학생의 수를 센 후 출력하기
            int highScoreCount = 0;
            for(int i = 0; i < examScores.Length; ++i)
            {
                if (80 <= examScores[i]) highScoreCount++;
            }
            Console.WriteLine($"80점 이상인 학생의 수 : {highScoreCount}");

            // 3.2 최고점 출력하기
            // int[] examScores = { 75, 92, 81, 68, 88, 95, 53 };

            // 임시 변수 활용하기
            int temp = 0;
            for (int i = 0; i < examScores.Length; ++i)
            {
                if (temp < examScores[i]) temp = examScores[i];
            }

            Console.WriteLine($"최고점 출력하기 : {temp}");

            // 임시 인덱스 변수 활용하기
            // int[] examScores = { 75, 92, 81, 68, 88, 95, 53 };
            int tempIndex = 0;
            for (int i = 1; i < examScores.Length; ++i)
            {
                if (examScores[tempIndex] < examScores[i]) tempIndex = i;
            }

            Console.WriteLine($"최고점 출력하기 : {examScores[tempIndex]}");

            // Q3 두번째로 큰수 찾기 (examScores에서 두번째로 큰수를 찾고, 출력)
            // int[] examScores = { 75, 92, 81, 68, 88, 95, 53 };
            int firstScore = int.MaxValue - 1;
            int secondScore = int.MaxValue;

            for (int i = 0; i < examScores.Length; ++i)
            {
                if (firstScore > examScores[i])
                {
                    // 기존 firstScore를 secondScore에 대입하고
                    secondScore = firstScore;
                    // firstScore를 갱신한다
                    firstScore = examScores[i];
                }
                else if (secondScore > examScores[i])
                {
                    secondScore = examScores[i];
                }
            }

            Console.WriteLine($"두번쟤로 낮은 점수 출력하기 : {secondScore}");
        }

        public void Struct()
        {

        }
    }
}
