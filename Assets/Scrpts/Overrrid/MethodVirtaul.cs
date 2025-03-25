using UnityEngine;

namespace Override
{
    public class MethodVirtaul : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Animal 클래스의 인스턴스 생성
            Animal animal = new Animal();
            animal.Eat();

            //Dog 클래스의 인스턴스 생성
           /* Dog dog = new Dog();
            dog.Eat();*/

            //Cat 클래스의 인스턴스 생성
            /*Cat cat = new Cat();
            cat.Eat();*/

            // 업 캐스팅 : 클래스의 다형성.
            //부모 클래스(Animal)의 변수에 자식 클래스(Dog)의 인스턴스 생성
            Animal aDog = new Dog(); //자식클래스의 인스턴스를 만들어서 부모 변수(aDog)에 저장
            aDog.Eat();

            Animal bCat = new Cat();
            bCat.Eat();
            
            /*Animal dog2 = new Dog();
            dog2.Eat();*/

        }
    }
}
