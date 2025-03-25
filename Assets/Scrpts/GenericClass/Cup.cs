using UnityEngine;

// Generic Class(제네릭 클래스) : 형식 매개 변수 T(데이터 Type)에 지정한 형식으로 클래스와 멤버의 성질이 결정되는 클래스
// Cup<T> : 컵어브티, 전용 컵.

namespace GenericClass
{
    public class Water { }

    public class Coffee { }

    //제네릭 클래스 만들기 - 클래스이름<T> 
    public class Cup<T>
    {
        public T Content { get; set; }
        //public Water Content { get; set; }
        //public string Content { get; set; }

        //매개변수로 입력받은 T형식 데이터를 출력하라
        public void PrintData(T data) //생성할때 T를 받아오기 때문에 <T>는 없어도 된다.
        {
            Debug.Log($"{data}");
        }
    }
}
