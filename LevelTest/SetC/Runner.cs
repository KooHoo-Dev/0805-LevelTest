namespace LevelTest.SetC;

public static class Runner
{
    public static void Run()
    {
        Grader.StartSet("SetC (12문제 / 60분)");

        Q01_NegateNumber.Check();
        Q02_GramFormat.Check();
        Q03_MaxPosition.Check();
        Q04_JobTitle.Check();
        Q05_MultipleOfThreeSum.Check();
        Q06_DigitCount.Check();
        Q07_InvertedTriangle.Check();
        Q08_Median.Check();
        Q09_PositiveFilter.Check();
        Q10_Palindrome.Check();
        Q11_TopPaidEmployee.Check();
        Q12_BelowAverageMovie.Check();

        Grader.EndSet();
    }
}
