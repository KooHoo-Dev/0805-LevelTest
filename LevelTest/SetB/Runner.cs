namespace LevelTest.SetB;

public static class Runner
{
    public static void Run()
    {
        Grader.StartSet("SetB (12문제 / 60분)");

        Q01_SquareNumber.Check();
        Q02_CmFormat.Check();
        Q03_AverageGrade.Check();
        Q04_DayOfWeek.Check();
        Q05_EvenSum.Check();
        Q06_DigitProduct.Check();
        Q07_RightTriangle.Check();
        Q08_SecondMin.Check();
        Q09_OddFilter.Check();
        Q10_TwoProduct.Check();
        Q11_LongestBook.Check();
        Q12_AboveAverageScore.Check();

        Grader.EndSet();
    }
}
