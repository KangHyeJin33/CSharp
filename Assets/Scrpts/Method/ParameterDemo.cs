using Mono.Cecil;
using UnityEngine;

namespace Methood
{
    public class ParameterDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //몬스터 생성
            Monster monster1 = new Monster(100, 10); //(첫 번째)몬스터 1마리 생성
            Monster.monsterCount++;
            Monster monster2 = new Monster(200, 20);
            Monster.monsterCount++;

            //전투
            //MonsterBattle(monster2, monster1); //공격 : 2. 방어 : 1.
            monster1.TakeDamage(monster2.atk);
            monster2.TakeDamage(monster1.atk);

            Debug.Log($"monster1 HP : {monster1.hp}, ATK : {monster1.atk}");
            Debug.Log($"monster2 HP : {monster2.hp}, ATK : {monster2.atk}");
            Debug.Log($"monsterCount : {Monster.monsterCount}");

        }

        //몬스터간의 1:1 전투 구현 : 
        void MonsterBattle(Monster atkMonser, Monster defMonster)
        {
            defMonster.hp -= atkMonser.atk; // 내 공격력으로 상대방의 hp를 깎음.
            atkMonser.hp -= defMonster.atk;

        }
    }

    //몬스터를 관리하는 클래스
    public class Monster
    {
        //필드 만들기
        //정적 멤버 변수 : 이 프로젝트 내에서 단 하나만 존재하는 값. 공유(Share)의 개념.
        //이 게임에서 생성된 몬스터 총 수량을 저장
        public static int monsterCount = 0;

        public int hp; // 전역변수.
        public int atk; // 전역변수.
     

        //생성자 만들기
        public Monster(int hp, int atk) // (int hp, int atk) : 로컬변수.
        {
            this.hp = hp; //this.변수 : 전역변수.
            this.atk = atk;
           
        }

        //데미지 입는 함수 만들기
        public void TakeDamage(/*Monster this,*/ int damage)
        {
            this.hp -= damage;
        }
    }
}