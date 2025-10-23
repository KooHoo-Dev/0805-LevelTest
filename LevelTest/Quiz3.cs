namespace LevelTest;

public class Quiz3
{
    // Quiz3 : 짝수의 개수 구하기
    //
    // 문제 설명:
    // 정수 배열 numbers가 주어집니다.
    // 배열에 포함된 요소 중 짝수의 개수를 구하여 반환하는 함수를 작성하세요.
    //
    // 규칙 및 요구사항:
    // - 배열의 각 요소를 순회하며 짝수인지 판별합니다.
    // - 짝수의 개수를 세어 반환합니다.
    //
    // 예시:
    // numbers = { 1, 2, 3, 4, 5 }
    // 짝수는 2개이므로 결과: 2
    public static int CountEvenNumber(int[] numbers)
    {
        int reVal = 0;

        for(int i = 0; i < numbers.Length; ++i)
        {
            if (numbers[i] % 2 == 0) reVal += 1; // reval = reval + 1; 이것과 같다.
        }

        return reVal;
    }
}