using System;

namespace Csharpe_Basic.Study
{
    // Struct?
    //  Struct는 "구조체"라고 불리며, 연관있는 데이터를
    // 하나의 의미있는 단위로 묶을 때 사용합니다.
    //  어떤 학생의 국어, 영어, 수학 점수를 각각 따로
    // 관리 하는 것보다 "학생"이라는 하나의 단위로 
    // 묶어서 묶음형태로 관리하면 훨씬 편리하며,
    // 데이터 액세스 측면에도 효율적 입니다.

    public struct Student
    {
        // # 멤버 변수
        // Struct나 Class 내부에 선언되어 데이터를 저장하는 변수
        // "public" 키워드는 외부에서 이 변수들에 접슨할 수 있도록
        // 허용하는 "접근 제한자" 키워드입니다

        public string Name;
        public int KoreanScore;
        public int EnglishScore;
        public int MathScore;
        
        // # 생성자
        // Struct나 Class가 처음 만들어질 때(인스턴스화 될 때)
        // 호출되는 특별한 메서드
        // 주로 멤버변수들을 초기화 하는 역할.
        public Student(string name, int koreanScore, 
            int englishScore, int mathScore)
        {
            Name = name;
            KoreanScore = koreanScore;
            EnglishScore = englishScore;
            MathScore = mathScore;
        }

        public override string ToString()
        {
            return $"{Name} : {KoreanScore}, {EnglishScore}, {MathScore}";
        }
    }
}
