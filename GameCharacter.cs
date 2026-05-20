using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Csharpe_Basic.Study.Type
{
    // # 클래스? : 관련있는 데이터를 의미있는 한 단위로 모아놓은 자료형
    // - 객체를 만들기 위한 "틀" 또는 "설계도" 입니다.
    // - 클래스 안에는 특정 대상이 가져야할 데이터(속성), 행동(기능)을
    //  함께 정의 합니다.
    // - 클래스를 디자인(설계) 한다는 건 객체의 의미를 프로그래밍적인
    // 데이터로 모델링 하는것입니다.
    
    // 클래스의 개념을 게임 캐릭터로 비유해서 캐릭터를 클래스화
    // 하는 방법을 알아봅시다
    // 정의해볼것은 "전사", "마법사", "궁서" 같은 직업과
    // 각 캐릭터들의 능력치(데이터)와 사용할 수 있는 스킬(행동) 입니다

    public class GameCharacter
    {
        // 멤버 변수 구역 (필드 구역)
        // - 클래스 내에서 사용할 변수, 함수(프로퍼티) 등을 정의해놓은 지역

        public string name;
        public int level;
        public int hp;
        public int maxHp;
        public int attackPower;

        // 원래 생성자가 들어갈 자리임. 이번에는 멤버 함수 설명으로 건너뜀

        // 멤버 함수 구역 (메서드 구역)
        

        // 아래처럼 정의된 "함수"를 "생성자"라고 합니다
        // 생성자의 구조
        
        // 접근제한자 클래스명 (매개변수들)
        // {
        //    함수 내용
        // }

        public GameCharacter(string name, int level, int maxHp, int attackPower)
        {
            // this는 클래스 내부에서 필드나 메서드에 접근하고 싶을때 사용하는 키워드.
            // this를 사용해서 서로 겹치는 네이밍을 회피할 수 있습니다.
            this.name = name;
            this.level = level;
            this.maxHp = maxHp;
            hp = maxHp;
            this.attackPower = attackPower;
        }


        public void AttackTo(GameCharacter target)
        {
            // target에게 공격을 가하는 로직을 작성해봅시다
            // target은 다른 게임 캐릭터가 들어옵니다

            Console.WriteLine($"[{name}] 캐릭터가 [{target.name}]을 공격합니다!");
            target.TakeDamage(attackPower);
        }

        public void TakeDamage(int damage)
        {
            // 매개변수로 들어온 damage만큼 나의 hp를 차감해줍니다.
            // 위의 AttackTo 함수의 target의 내부에서 아래 로직이 실행 됩니다.
            hp -= damage;
            if(hp <= 0) Die();
            else        Console.WriteLine($"[{name}] 캐릭터가 {damage} 만큼의 피해를 입었습니다");
        }

        public void Die()
        {
            Console.WriteLine($"{name} 캐릭터가 쓰러졌습니다.");
        }

        public void LevelUp()
        {
            level++;
            maxHp += 10;
            hp = maxHp; // 피 채우기
            attackPower += 5;
            Console.WriteLine($" 레벨업! [{name}] 님의 레벨이 {level}이 되었습니다!");
        }

        public void ShowStatus()
        {
            Console.WriteLine("----- 캐릭터 정보 -----");
            Console.WriteLine($" 이름 : {name}");
            Console.WriteLine($" 레벨 : {level}");
            Console.WriteLine($" 체력 : {hp} / {maxHp}");
            Console.WriteLine($" 공격력 : {attackPower}");
            Console.WriteLine("----------------------");
        }
    }

    
}
