namespace LevelTest;

public class Quiz0
{
    // Quiz0 : 컴파일 에러 수정하기
    //
    // 문제 설명:
    // 아래의 함수는 1부터 매개변수 N까지의 모든 숫자를 더하는 "누적합 출력기"입니다.
    // 아래의 함수는 컴파일이 되지 않는 상태이며, 반복문이 작동하지 않는 상태입니다. 
    // IDE에 표시되는 컴파일 에러 메시지를 분석하여 원인을 찾고,
    // 코드를 수정하여 컴파일 에러, 반복문이 실행되지 않는 문제를 해결하세요.
    public static void SumPrinter(int n)
    {
        Console.WriteLine("\n--- 누적합 출력기 ---");

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine($"1부터 {n}까지의 누적 합은 {sum}입니다.");
    }
    
    
}