namespace LevelTest.SetA;

// Q12에서 사용되는 상품 구조체. (시험 문제이므로 구조체 정의는 미리 제공됩니다)
public struct Product
{
    public string Name;
    public int Price;

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString() => $"{{{Name}, {Price}}}";
}

public static class Q12_AboveAveragePrice
{
    // Q12 (구조체 - 집계) : 평균가 이상의 상품 개수 세기
    //
    // 문제 설명:
    //   상품 구조체(Product) 배열이 주어집니다. Product는 다음 필드를 가집니다.
    //     - string Name  : 상품명
    //     - int    Price : 가격
    //
    //   상품들의 평균 가격을 구한 뒤, 평균 가격 "이상"인 상품의 개수를 반환하세요.
    //
    // 규칙:
    //   - 배열이 비어 있으면 0을 반환합니다.
    //   - 평균은 정수 나눗셈이 아니라 실수(double 등)로 계산하세요.
    //     예) 가격이 {100, 200, 301}이면 평균 = 200.333...
    //         → 200, 301 은 평균 미만/이상? 200 < 200.333 이므로 200은 미만, 301만 이상 → 1
    //   - 평균과 정확히 같은 가격도 "평균가 이상"에 포함합니다.
    //
    // 예시:
    //   [ (A,100), (B,200), (C,300) ]                 → 2   (평균 200, 이상은 200, 300)
    //   [ (A,100), (B,200), (C,301) ]                 → 1   (평균 200.33..., 이상은 301)
    //   [ (X,50) ]                                    → 1   (평균 50, 이상은 50 자신)
    //   [ ]                                           → 0

    public static int Solve(Product[] products)
    {
        throw new NotImplementedException();
    }

    public static Product[][] Inputs =
    {
        new[] { new Product("A", 100), new Product("B", 200), new Product("C", 300) },
        new[] { new Product("A", 100), new Product("B", 200), new Product("C", 301) },
        new[] { new Product("X", 50) },
        new Product[] { },
        new[] { new Product("a", 10), new Product("b", 20), new Product("c", 30), new Product("d", 40) },
        new[] { new Product("p", 1000), new Product("q", 1000), new Product("r", 1000) },
    };
    public static int[] Expected = { 2, 1, 1, 0, 2, 3 };

    public static void Check() => Grader.Run("Q12 (평균가 이상 상품 수)", Inputs, Expected, Solve);
}
