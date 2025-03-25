using UnityEngine;

namespace Override
{
    public class InheritanceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Player클래스 인스턴스 만들기
            Player player = new Player(100, 30); //hp : 100, ATK : 30.

            //몬스터 클래스 인스턴스 생성
            Goblin go = new Goblin(50, 10);
            Skeleton sk = new Skeleton(100, 20);
            Zombie zb = new Zombie(200, 30);

            //전투
            player.TakeDamage(go);
            DrawHealth(player);
            player.TakeDamage(sk);
            DrawHealth(player);
            player.TakeDamage(zb);
            DrawHealth(player);

            go.TakeDamage(player);
            DrawHealth(go);
            sk.TakeDamage(player);
            DrawHealth(sk);
            zb.TakeDamage(player);
            DrawHealth(zb);



        }
        //캐릭터의 health 그리기
        public void DrawHealth(Characer ch)
        {
            Debug.Log($"{ch} : {ch.health}");
        }

       /* public void DrawPlayerGealth(Player player)
        {
            Debug.Log($"{player.health}");
        }

        public void DrawGoblinGealth()
        {

        }

        public void DrawSkeletonGealth()
        {

        }

        public void ZombiGealth()
        {

        }*/
    }
}
