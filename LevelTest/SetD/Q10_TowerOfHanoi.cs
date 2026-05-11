namespace LevelTest.SetD;

public static class Q10_TowerOfHanoi
{
    // Q10 : 하노이의 탑 (Tower of Hanoi)
    //
    // 문제 설명:
    // 세 개의 기둥(A, B, C)과 크기가 서로 다른 N개의 원판이 있습니다.
    // 모든 원판은 처음에 기둥 A에 쌓여 있으며, 이를 규칙에 따라 기둥 C로 모두 옮기려고 합니다.
    // 
    // 규칙:
    // 1. 한 번에 하나의 원판만 옮길 수 있습니다.
    // 2. 큰 원판은 작은 원판 위에 올 수 없습니다.
    // 3. 세 개의 기둥 중 하나를 보조 기둥으로 사용할 수 있습니다.
    //
    // 요구사항:
    // - 원판의 개수 N을 매개변수로 받아,
    //   모든 원판을 A → C로 옮기는 데 필요한 **총 이동 횟수**를 반환하는 함수를 작성하세요.
    // - 이동 과정은 "A → B" 형태로 출력할 수 있습니다. (출력은 선택 사항입니다.)
    //
    // 예시:
    // 입력: N = 3
    // 출력:
    // A → C
    // A → B
    // C → B
    // A → C
    // B → A
    // B → C
    // A → C
    //
    // 총 이동 횟수: 7

    public static int Solve(int n)
    {
        throw new NotImplementedException();
    }

    public static int[] Inputs = { 15, 16, 17, 18, 19, 20, 21 };
    public static int[] Expected = { 32767, 65535, 131071, 262143, 524287, 1048575, 2097151 };
    
    public static void Check() => Grader.Run("Q10 (하노이의 탑)", Inputs, Expected, Solve);
}