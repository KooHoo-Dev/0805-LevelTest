namespace LevelTest.SetD;

public class Q11_StairClimbing
{
    // Q7 : (동적계획법 - 1차원) : 계단 오르기
    //
    // 문제 설명:
    //   n개의 계단을 오를 때, 한 번에 1칸, 2칸, 또는 3칸씩 오를 수 있습니다.
    //   n번째 계단에 도달하는 서로 다른 방법의 수를 반환하세요.
    //
    // 규칙:
    //   - 1 ≤ n ≤ 30
    //   - 오르는 순서가 다르면 서로 다른 방법으로 간주합니다.
    //     (예: n=3일 때 1+2와 2+1은 서로 다른 방법)
    //      
    // 예시:
    //   1  → 1    (1)
    //   2  → 2    (1+1, 2)
    //   3  → 4    (1+1+1, 1+2, 2+1, 3)
    //   4  → 7
    //   5  → 13
    //   10 → 274

    public static int Solve(int n)
    {
        throw new NotImplementedException();
    }

    public static int[] Inputs = { 1, 2, 3, 4, 5, 10, 15, 20 };
    public static int[] Expected = { 1, 2, 4, 7, 13, 274, 5768, 121415 };

    public static void Check() => Grader.Run("Q11 (계단 오르기)", Inputs, Expected, Solve);
}