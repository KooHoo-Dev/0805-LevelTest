namespace LevelTest.SetD;

public class Q02_LogicError
{
    // Q2 : 논리적 에러 해결
    //
    // 문제 설명:
    //    1 ~ input 까지의 모든 정수를 곱하여 반환하는 함수를 작성중입니다.
    //   코드를 작성하고 실행해보니, 생각과는 다른 결과가 출력되었습니다.
    //   에러를 분석하여 코드를 수정하세요.
    //
    // 규칙:
    //   - input는 양의 정수로 주어집니다.
    //   - 최종 결과값은 int로 표현할 수 있는 가장 높은값을 초과하지 않습니다.
    
    public static int Solve(int input)
    {
        int sum = 0;
        for (int i = 0; i < input; i++)
        {
            sum *= i;
        }
        
        return sum;
    }
    
    public static int[] Inputs = { 1, 5, 7, 10, 12 };
    public static int[] Expected = { 1, 120, 5040, 3628800, 479001600 };

    public static void Check() => Grader.Run("Q2 논리적 에러 해결", Inputs, Expected, Solve);
}