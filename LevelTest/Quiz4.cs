namespace LevelTest;

public class Quiz4
{
    // Quiz4 : 주어진 구간 사이의 모든 정수의 합 구하기
    //
    // 문제 설명:
    // 두 개의 정수 startNum과 endNum이 매개변수로 주어집니다.
    // startNum과 endNum 사이의 모든 정수를 더한 값을 결과로 반환하는 함수를 작성하세요.
    //
    // 규칙 및 요구사항:
    // - 시작 수(startNum)와 끝 수(endNum)를 포함하여 계산합니다.
    //
    // 예시:
    // startNum = 1, endNum = 5
    // 계산 과정: 1 + 2 + 3 + 4 + 5 = 15
    // 결과: 15

    public static int SumRange(int startNum ,int endNum)
    {
        //예외 처리 startNum과 endNum이 같을때
        if (startNum == endNum) return startNum + endNum;

        int minNumber = startNum;
        int maxNumber = endNum;

        //예외 처리 : startNumber가 endNumber보다 클 경우
        if (startNum > endNum)
        {
            minNumber = endNum;
            maxNumber = startNum;
        }

        int sum = 0;

        for(int i = minNumber; i <= maxNumber; ++i)
        {
            sum += i;
        }

        return sum;
    }
}