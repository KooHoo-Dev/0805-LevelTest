namespace LevelTest.SetD;

public class Runner
{
    public static void Run()
    {
        Grader.StartSet("SetC (12문제 / 60분)");

        Q01_CompileError.Check();
        Q02_LogicError.Check();
        Q03_Season.Check();
        Q04_OddSum.Check();
        Q05_SecondMax.Check();
        Q06_OddFilter.Check();
        Q07_ReverseArray.Check();
        Q08_TwoProduct.Check();
        Q09_LongestBook.Check();
        Q10_TowerOfHanoi.Check();
        Q11_StairClimbing.Check();
        Q12_TextRPG.Check();

        Grader.EndSet();
    }
}