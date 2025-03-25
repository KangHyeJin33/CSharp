using UnityEngine;

namespace GenericClass
{
    //제네릭 클래스 만들기 - 설계
    public class Hello<T>
    {
        //필드
        private T _message;

        //생성자(매개변수가 없으면 기본 생성자) - 필드 초기화 역할
        public Hello()
        {
           this._message = default(T);
           this._message = default(T);
        }

        public Hello(T message)
        {
            _message = message;
        }

        //메서드
        public void Say(T message)
        {
            Debug.Log($"{message}");
        }

        public T GetMessage() => this._message;
    }
}
