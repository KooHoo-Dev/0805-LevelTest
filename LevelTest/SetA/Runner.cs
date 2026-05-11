namespace LevelTest.SetA;

public static class Runner
{
    public static void Run()
    {
        Grader.StartSet("SetA (12문제 / 60분)");

        Q01_DoubleNumber.Check();
        Q02_TimeFormat.Check();
        Q03_TriangleType.Check();
        Q04_Season.Check();
        Q05_OddSum.Check();
        Q06_DigitSum.Check();
        Q07_LeftTriangle.Check();
        Q08_SecondMax.Check();
        Q09_EvenFilter.Check();
        Q10_TwoSum.Check();
        Q11_TopStudent.Check();
        Q12_AboveAveragePrice.Check();

        Grader.EndSet();
    }
}
