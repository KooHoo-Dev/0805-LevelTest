using System.Runtime.CompilerServices;

namespace LevelTest;

public class Quiz6
{
    // Quiz6 : 하노이의 탑 (Tower of Hanoi)
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


    //내 위에 녀석 들을 빈 기둥으로 옮긴다.
    //나를 목표 기둥으로 옮기고
    //빈 기둥으로 옮긴 녀석들을 목표 기둥으로 옮긴다

    public static int RunHanoi(int n, string start, string goal, string temp)
    {
        int totalCount = 0;

        if(n == 1)
        {
            Console.WriteLine($"{n}을 {start} => {goal}");
            return 1;
        }

        totalCount += RunHanoi(n - 1, start, temp, goal);
        Console.WriteLine($"{n}을 {start} => {goal}");
        totalCount++;
        totalCount += RunHanoi(n - 1, temp, goal, start);

        return totalCount;
    }
}