using UnityEngine;


namespace Override
{
    //플레이어(..), 몬스터(슬라임, 좀비, 고블린, ...)
    //모든 캐릭터의 추상(abstract) 부모 클래스(캐릭터가 가지고 있는 공통 특성, 기능)
    public abstract class Characer //추상클래스(Characer)
    {
        public abstract int GetTotanAttack();
        public int health;
        public int baseAtk;

        //생성자
        public Characer(int hp, int atk)
        {
            this.health = hp;
            this.baseAtk = atk;
        }
        
        //매개변수로 나를 공격하는 캐릭터 객체를 전달 해준다.
        public void TakeDamage(Characer other)
        {
            health -= other.GetTotanAttack(); //기본 공격력 + 다른 공격력
        }
    }

    //플레이어 
    public class Player : Characer
    {
        public Player() : this(10, 20) { } //Player()를 빈 공간으로 생성하고 hp 10, atk 20으로 저장.
        public Player(int hp, int atk) : base(hp, atk) { }

        public override int GetTotanAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //장비
            //스킬
            //상성

            return total;
        }

    }
    //몬스터 : 슬라임, 좀비, 고블린, ... 등의 부모 클래스
    public class Monster : Characer
    {
        //생성자
        public Monster(int hp, int atk) : base(hp, atk) { }

        
        public override int GetTotanAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //스킬
            //상성

            return total;
        }

        // 슬라임, 좀비, 고블린, ... 공통 기능 구현
        //...
    }

    //고블린
    public class Goblin : Monster
    {
        //특성
        public int posX, posY;

        //생성자
        public Goblin(int hp, int atk) : base(hp, atk) { }

        public override int GetTotanAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //스킬
            //상성

            return total;
        }

        public void SetPosition(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }
    }
    //스켈레톤
    public class Skeleton : Monster
    {
        //생성자
        public Skeleton(int hp, int atk) : base(hp, atk) { }

        public override int GetTotanAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //스킬
            //상성

            return total;
        }
    }

    //좀비
    public class Zombie : Monster
    {
        //생성자
        public Zombie(int hp, int atk) : base(hp, atk) { }

        public override int GetTotanAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //스킬
            //상성

            return total;
        }
    }
}
