namespace LevelTest;

public class LoopQuiz
{
    public void Run()
    {
        // For loops
        F1();
        F2();
        F3();
        F4();
        F5();
        F6();
        F7();
        F8();

        // While loops
        W1();
        W2();
        W3();
        W4();
        W5();
        W6();
        W7();
        W8();

        // Do-While loops
        DW1();
        DW2();
        DW3();
        DW4();

        // Array & Loop Quizzes
        A1();
        A2();
        A3();
        A4();
        A5();
        A6();
        A7();
        A8();
        A9();
        A10();
    }

    // --- For-Loop Quizzes ---

    // F1 : 1부터 10까지 출력하기
    static void F1()
    {
        // TODO: for문을 사용하여 1부터 10까지의 숫자를 한 줄에 하나씩 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("F1: 1부터 10까지 출력하기");
        //--- 아래부터 코드 작성  ---

    }

    // F2 : 1부터 20까지의 짝수만 출력하기
    static void F2()
    {
        // TODO: for문과 if문을 사용하여 1부터 20까지의 숫자 중 짝수만 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("F2: 1부터 20까지의 짝수만 출력하기");
        //--- 아래부터 코드 작성  ---

    }

    // F3 : 1부터 입력받은 수까지의 합 구하기
    static void F3()
    {
        // TODO: 사용자에게 숫자 N을 입력받아, for문을 사용하여 1부터 N까지의 합을 계산하고 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("F3: 1부터 입력받은 수까지의 합 구하기");
        Console.Write("숫자를 입력하세요: ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n < 1)
        {
            Console.WriteLine("F3: 1 이상의 양수를 입력해야 합니다. 다음 문제로 넘어갑니다.");
            return;
        }
        //--- 아래부터 코드 작성  ---

    }

    // F4 : 구구단 출력하기
    static void F4()
    {
        // TODO: 사용자에게 숫자 N을 입력받아, for문을 사용하여 N단의 구구단을 출력하세요. (예: N * 1 = N, N * 2 = 2N, ...)
        Console.WriteLine("---");
        Console.WriteLine("F4: 구구단 출력하기");
        Console.Write("구구단 몇 단을 출력할까요? (2-9): ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 9)
        {
            Console.WriteLine("F4: 2와 9 사이의 숫자를 입력해야 합니다. 다음 문제로 넘어갑니다.");
            return;
        }
        //--- 아래부터 코드 작성  ---

    }

    // F5 : 10부터 1까지 거꾸로 출력하기
    static void F5()
    {
        // TODO: for문을 사용하여 10부터 1까지의 숫자를 거꾸로 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("F5: 10부터 1까지 거꾸로 출력하기");
        //--- 아래부터 코드 작성  ---

    }

    // F6 : 팩토리얼 계산하기
    static void F6()
    {
        // TODO: 사용자에게 숫자 N을 입력받아, for문을 사용하여 N의 팩토리얼(N!)을 계산하고 출력하세요. (0! = 1)
        Console.WriteLine("---");
        Console.WriteLine("F6: 팩토리얼 계산하기");
        Console.Write("숫자를 입력하세요 (0 이상): ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.WriteLine("F6: 0 이상의 정수를 입력해야 합니다. 다음 문제로 넘어갑니다.");
            return;
        }
        //--- 아래부터 코드 작성  ---

    }

    // F7 : 별 찍기 (오른쪽 위가 직각인 삼각형)
    static void F7()
    {
        // TODO: 사용자에게 숫자 N을 입력받아, N층의 별 삼각형을 출력하세요.
        // 예) N=5
        // *
        // **
        // ***
        // ****
        // *****
        Console.WriteLine("---");
        Console.WriteLine("F7: 별 찍기");
        Console.Write("몇 층의 별 삼각형을 만들까요?: ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("F7: 양의 정수를 입력해야 합니다. 다음 문제로 넘어갑니다.");
            return;
        }
        //--- 아래부터 코드 작성  ---

    }

    // F8 : 숫자의 약수 찾기
    static void F8()
    {
        // TODO: 사용자에게 숫자 N을 입력받아, for문을 사용하여 N의 모든 약수를 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("F8: 숫자의 약수 찾기");
        Console.Write("숫자를 입력하세요: ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("F8: 양의 정수를 입력해야 합니다. 다음 문제로 넘어갑니다.");
            return;
        }
        Console.Write($"F8: {n}의 약수: ");
        //--- 아래부터 코드 작성  ---

    }

    // --- While-Loop Quizzes ---

    // W1 : 0을 입력할 때까지 계속 입력받기
    static void W1()
    {
        // TODO: while문을 사용하여, 사용자가 0을 입력할 때까지 계속해서 숫자를 입력받으세요. 0이 입력되면 "프로그램 종료"를 출력하고 루프를 빠져나옵니다.
        Console.WriteLine("---");
        Console.WriteLine("W1: 0을 입력할 때까지 계속 입력받기 (0 입력 시 종료)");
        //--- 아래부터 코드 작성  ---

    }

    // W2 : 음수가 입력될 때까지 합계 구하기
    static void W2()
    {
        // TODO: while문을 사용하여, 사용자가 음수를 입력할 때까지 계속해서 숫자를 입력받고, 그 숫자들의 합계를 구하여 출력하세요. (음수는 합계에 포함하지 않음)
        Console.WriteLine("---");
        Console.WriteLine("W2: 음수가 입력될 때까지 합계 구하기 (음수 입력 시 종료)");
        //--- 아래부터 코드 작성  ---

    }

    // W3 : 숫자 맞추기 게임
    static void W3()
    {
        // TODO: while문을 사용하여 간단한 숫자 맞추기 게임을 만드세요. 정답은 7입니다. 사용자가 7을 입력할 때까지 "틀렸습니다. 다시 시도하세요." 메시지를 출력하며 계속 입력을 받으세요. 7을 입력하면 "정답입니다!"를 출력하고 루프를 종료합니다.
        Console.WriteLine("---");
        Console.WriteLine("W3: 숫자 맞추기 게임 (1-10 사이의 숫자를 맞춰보세요)");
        //--- 아래부터 코드 작성  ---

    }

    // W4 : 1부터 N까지 출력하기 (while 사용)
    static void W4()
    {
        // TODO: 사용자에게 숫자 N을 입력받아, while문을 사용하여 1부터 N까지의 숫자를 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("W4: 1부터 N까지 출력하기 (while 사용)");
        Console.Write("숫자를 입력하세요: ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n < 1)
        {
            Console.WriteLine("W4: 1 이상의 양수를 입력해야 합니다. 다음 문제로 넘어갑니다.");
            return;
        }
        //--- 아래부터 코드 작성  ---

    }

    // W5 : N부터 1까지 카운트다운 (while 사용)
    static void W5()
    {
        // TODO: 사용자에게 숫자 N을 입력받아, while문을 사용하여 N부터 1까지 카운트다운을 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("W5: N부터 1까지 카운트다운 (while 사용)");
        Console.Write("숫자를 입력하세요: ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n < 1)
        {
            Console.WriteLine("W5: 1 이상의 양수를 입력해야 합니다. 다음 문제로 넘어갑니다.");
            return;
        }
        //--- 아래부터 코드 작성  ---

    }

    // W6 : 메뉴 선택 시뮬레이션
    static void W6()
    {
        // TODO: while문을 사용하여 메뉴 선택 시뮬레이션을 만드세요.
        // 1. "1: 보기, 2: 쓰기, 3: 수정, 4: 종료" 메뉴를 보여줍니다.
        // 2. 사용자가 4를 입력할 때까지 계속해서 메뉴 번호를 입력받습니다.
        // 3. 각 메뉴 번호에 대해 "X번 메뉴를 선택했습니다."를 출력합니다.
        // 4. 4를 입력하면 "프로그램을 종료합니다."를 출력하고 루프를 종료합니다.
        Console.WriteLine("---");
        Console.WriteLine("W6: 메뉴 선택 시뮬레이션");
        //--- 아래부터 코드 작성  ---

    }

    // W7 : 1000을 넘는 첫 번째 2의 거듭제곱 찾기
    static void W7()
    {
        // TODO: while문을 사용하여 2의 거듭제곱 중 1000을 넘는 첫 번째 값을 찾아 출력하세요. (2, 4, 8, 16, ...)
        Console.WriteLine("---");
        Console.WriteLine("W7: 1000을 넘는 첫 번째 2의 거듭제곱 찾기");
        //--- 아래부터 코드 작성  ---

    }

    // W8 : 숫자 뒤집기
    static void W8()
    {
        // TODO: 사용자에게 양의 정수 N을 입력받아, while문을 사용하여 그 숫자를 뒤집어 출력하세요. (예: 12345 -> 54321)
        Console.WriteLine("---");
        Console.WriteLine("W8: 숫자 뒤집기");
        Console.Write("뒤집을 양의 정수를 입력하세요: ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("W8: 양의 정수를 입력해야 합니다. 다음 문제로 넘어갑니다.");
            return;
        }
        //--- 아래부터 코드 작성  ---

    }

    // --- Do-While-Loop Quizzes ---

    // DW1 : 올바른 비밀번호를 입력할 때까지 반복
    static void DW1()
    {
        // TODO: do-while문을 사용하여, 비밀번호("1234")를 맞출 때까지 계속해서 입력을 요구하는 프로그램을 작성하세요. 비밀번호를 맞추면 "로그인 성공"을 출력합니다.
        Console.WriteLine("---");
        Console.WriteLine("DW1: 올바른 비밀번호를 입력할 때까지 반복 (비밀번호: 1234)");
        //--- 아래부터 코드 작성  ---
    }

    // DW2 : 유효한 입력값 받기 (1-10)
    static void DW2()
    {
        // TODO: do-while문을 사용하여, 사용자에게 1에서 10 사이의 숫자를 입력하도록 요청하세요. 유효한 범위의 숫자가 입력될 때까지 반복하고, 유효한 숫자가 입력되면 "입력 성공: {number}"를 출력합니다.
        Console.WriteLine("---");
        Console.WriteLine("DW2: 1에서 10 사이의 유효한 숫자 입력받기");
        //--- 아래부터 코드 작성  ---

    }

    // DW3 : 계속할지 묻는 계산기
    static void DW3()
    {
        // TODO: do-while문을 사용하여 간단한 덧셈 계산기를 만드세요.
        // 1. 두 숫자를 입력받아 합계를 출력합니다.
        // 2. 사용자에게 "계속하시겠습니까? (y/n)"라고 묻습니다.
        // 3. 사용자가 'y' 또는 'Y'를 입력하면 루프를 계속하고, 그렇지 않으면 종료합니다.
        Console.WriteLine("---");
        Console.WriteLine("DW3: 계속할지 묻는 덧셈 계산기");
        //--- 아래부터 코드 작성  ---

    }

    // DW4 : 1부터 N까지의 합 구하기 (do-while 사용)
    static void DW4()
    {
        // TODO: 사용자에게 숫자 N을 입력받아, do-while문을 사용하여 1부터 N까지의 합을 계산하고 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("DW4: 1부터 N까지의 합 구하기 (do-while 사용)");
        Console.Write("숫자를 입력하세요: ");
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n < 1)
        {
            Console.WriteLine("DW4: 1 이상의 양수를 입력해야 합니다. 다음 문제로 넘어갑니다.");
            return;
        }
        //--- 아래부터 코드 작성  ---
    }

    // --- Array & Loop Quizzes ---

    // A1 : 배열의 모든 요소 출력하기
    static void A1()
    {
        // TODO: for문을 사용하여 주어진 배열(numbers)의 모든 요소를 한 줄에 하나씩 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("A1: 배열의 모든 요소 출력하기");
        int[] numbers = { 5, 10, 15, 20, 25 };
        //--- 아래부터 코드 작성  ---

    }

    // A2 : 배열에서 특정 값의 개수 세기
    static void A2()
    {
        // TODO: 주어진 배열(scores)에서 85점 이상인 점수의 개수를 세어 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("A2: 85점 이상인 점수의 개수 세기");
        int[] scores = { 78, 92, 85, 100, 67, 88, 95, 85 };
        //--- 아래부터 코드 작성  ---

    }

    // A3 : 배열의 합계와 평균 구하기
    static void A3()
    {
        // TODO: 주어진 배열(data)의 모든 요소의 합계와 평균을 계산하여 출력하세요. (평균은 소수점까지 나타내세요)
        Console.WriteLine("---");
        Console.WriteLine("A3: 배열의 합계와 평균 구하기");
        int[] data = { 10, 20, 30, 40, 50 };
        //--- 아래부터 코드 작성  ---

    }

    // A4 : 배열에서 최댓값과 최솟값 찾기
    static void A4()
    {
        // TODO: 주어진 배열(heights)에서 가장 큰 값(최댓값)과 가장 작은 값(최솟값)을 찾아 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("A4: 배열에서 최댓값과 최솟값 찾기");
        int[] heights = { 155, 178, 165, 181, 160, 172 };
        //--- 아래부터 코드 작성  ---

    }

    // A5 : 배열의 요소 거꾸로 출력하기
    static void A5()
    {
        // TODO: for문을 사용하여 주어진 배열(items)의 요소를 거꾸로(마지막 요소부터 첫 요소까지) 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("A5: 배열의 요소 거꾸로 출력하기");
        char[] items = { 'a', 'b', 'c', 'd', 'e' };
        //--- 아래부터 코드 작성  ---

    }

    // A6 : 배열의 짝수만 골라 새 배열에 담기
    static void A6()
    {
        // TODO: 주어진 배열(source)에서 짝수만 골라내어 'evenNumbers'라는 새로운 배열에 저장하고, 'evenNumbers' 배열의 모든 요소를 출력하세요.
        // 힌트: 새 배열을 만들려면 먼저 짝수가 몇 개인지 세어야 합니다.
        Console.WriteLine("---");
        Console.WriteLine("A6: 배열의 짝수만 골라 새 배열에 담기");
        int[] source = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //--- 아래부터 코드 작성  ---

    }

    // A7 : 두 배열이 완전히 같은지 확인하기
    static void A7()
    {
        // TODO: 두 배열(array1, array2)의 길이가 같고, 모든 요소가 순서대로 동일한지 확인하여 "두 배열은 같습니다." 또는 "두 배열은 다릅니다."를 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("A7: 두 배열이 완전히 같은지 확인하기");
        int[] array1 = { 10, 20, 30 };
        int[] array2 = { 10, 20, 30 };
        int[] array3 = { 10, 20, 40 };
        // array1과 array2를 비교하고, 그 다음 array1과 array3을 비교해보세요.
        //--- 아래부터 코드 작성  ---

    }

    // A8 : 배열에서 특정 값의 위치(인덱스) 찾기
    static void A8()
    {
        // TODO: 주어진 배열(students)에서 "김철수"라는 학생이 몇 번째 위치(인덱스)에 있는지 찾아 출력하세요.
        // 만약 "김철수"를 찾으면, 루프를 더 이상 진행하지 않도록 분기문(break)을 사용하세요.
        // 만약 학생이 없다면 "해당 학생을 찾을 수 없습니다."라고 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("A8: 배열에서 '김철수'의 위치 찾기");
        string[] students = { "이영희", "박지성", "김철수", "최유리" };
        //--- 아래부터 코드 작성  ---

    }

    // A9 : 문자열 배열에서 가장 긴 이름 찾기
    static void A9()
    {
        // TODO: 주어진 문자열 배열(names)에서 가장 이름이 긴 사람의 이름을 찾아 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("A9: 가장 긴 이름 찾기");
        string[] names = { "제임스", "엘리자베스", "알렉산더", "소피아" };
        //--- 아래부터 코드 작성  ---

    }

    // A10 : 배열의 특정 요소 바꾸기
    static void A10()
    {
        // TODO: 주어진 배열(numbers)에서 0보다 작은 수(음수)를 모두 0으로 바꾼 후, 전체 배열을 출력하세요.
        Console.WriteLine("---");
        Console.WriteLine("A10: 배열의 음수를 0으로 바꾸기");
        int[] numbers = { 10, -5, 3, -1, 0, 8, -2 };
        //--- 아래부터 코드 작성  ---

    }
}