namespace LevelTest;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 시험 시 풀이할 세트 한 줄만 활성화하세요.
        //SetA.Runner.Run();
        // SetB.Runner.Run();
        // SetC.Runner.Run();
        SetD.Runner.Run();

        // 연습용 (자동채점 없음, 직접 콘솔 출력 확인)
        // new LoopQuiz().Run();
        // new CSharpEducation.Loops.LoopQuizExtended().Run();
    }
}
