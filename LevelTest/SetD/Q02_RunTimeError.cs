namespace LevelTest.SetD;

public class Q02_RunTimeError
{
    // Q2 런타임 에러 해결
    //
    // 문제 설명:
    //    0 ~ input 까지의 모든 정수를 더하여 반환하는 함수를 작성중입니다.
    //   코드를 작성하던 도중, 아래처럼 컴파일 에러가 발생했습니다.
    //   컴파일 에러를 분석하여 코드를 완성하세요.
    //
    
    
    public static int Solve(int input)
    {
        int sum = 0;
        for (int i = 0; i <= input; i++)
        {
            sum += i;
        }

        return sum;
    }
    
    public static int[] Inputs = { 10, 5, 100, 20, 4 };
    public static int[] Expected = { 55, 15, 5050, 210, 10 };

    public static void Check() => Grader.Run("Q1 컴파일 에러 해결", Inputs, Expected, Solve);
}