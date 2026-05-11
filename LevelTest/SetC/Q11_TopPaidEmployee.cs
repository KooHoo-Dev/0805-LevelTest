namespace LevelTest.SetC;

// Q11에서 사용되는 직원 구조체. (시험 문제이므로 구조체 정의는 미리 제공됩니다)
public struct Employee
{
    public string Name;
    public int Salary;

    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    public override string ToString() => $"{{{Name}, {Salary}}}";
}

public static class Q11_TopPaidEmployee
{
    // Q11 (구조체 - 탐색) : 연봉이 가장 높은 직원의 이름 반환
    //
    // 문제 설명:
    //   직원 구조체(Employee) 배열이 주어집니다. Employee는 다음 필드를 가집니다.
    //     - string Name   : 이름
    //     - int    Salary : 연봉
    //
    //   연봉이 가장 높은 직원의 Name을 반환하세요.
    //
    // 규칙:
    //   - 배열의 길이는 항상 1 이상입니다.
    //   - 최고 연봉이 동점인 직원이 여러 명이면, 배열에서 더 앞에 있는 직원의 이름을 반환합니다.
    //
    // 예시:
    //   [ ("김", 5000), ("이", 6000), ("박", 5500) ]   → "이"
    //   [ ("A", 7000), ("B", 7000), ("C", 6000) ]      → "A"
    //   [ ("혼자", 3000) ]                              → "혼자"

    public static string Solve(Employee[] employees)
    {
        throw new NotImplementedException();
    }

    public static Employee[][] Inputs =
    {
        new[] { new Employee("김", 5000), new Employee("이", 6000), new Employee("박", 5500) },
        new[] { new Employee("A", 7000), new Employee("B", 7000), new Employee("C", 6000) },
        new[] { new Employee("혼자", 3000) },
        new[] { new Employee("X", 1), new Employee("Y", 2), new Employee("Z", 3) },
        new[] { new Employee("최", 4500), new Employee("정", 9000), new Employee("강", 8500) },
    };
    public static string[] Expected = { "이", "A", "혼자", "Z", "정" };

    public static void Check() => Grader.Run("Q11 (최고 연봉 직원)", Inputs, Expected, Solve);
}
