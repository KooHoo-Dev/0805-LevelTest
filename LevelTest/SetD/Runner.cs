namespace LevelTest.SetD;

public class Runner
{
    public static void Run()
    {
        Grader.StartSet("SetC (12문제 / 60분)");

        Q01_Debug_CompileError.Check();
        

        Grader.EndSet();
    }
}