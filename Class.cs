using Csharpe_Basic.Study.Type;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Csharpe_Basic.Study
{
    public class Class
    {
        public void Run()
        {
            // 실습 :  텍스트 RPG 만들어보기

            GameCharacter warrior = new GameCharacter("전사", 10, 100, 20);
            GameCharacter mage = new GameCharacter("마법사", 10, 100, 10);

            while(true)
            {
                if (warrior.hp <= 0) break;
                if (mage.hp <= 0) break;

                Console.WriteLine($"===========");
                Console.WriteLine($"번호를 입력하세요!");
                Console.WriteLine($"1 : 공격");
                Console.WriteLine($"2 : 레벨업");

                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        warrior.AttackTo(mage);
                        break;
                    case "2":
                        warrior.LevelUp();
                        break;
                    default:
                        Console.WriteLine(" 잘못된 입력");
                        break;
                }

                if(mage.hp > 0) mage.AttackTo(warrior);
                warrior.ShowStatus();
                mage.ShowStatus();



            }
        }
    }
}
