using UnityEngine;

namespace PrivatePulic
{
    public class Car
    {
        // 필드 선언(전역변수, 멤버변수) - public(외부에서 접근 가능), private(외부에서 접근 불가능).
        public string name; //이름 (외부에서 접근 가능)
        private string age; //나이 (외부에서 접근 불가능)
        string address; //주소 (접근제한자가 생략되면 기본값인 private으로 설정 - 외부에서 접근 불가능)

        // 멤버 메서드 - public, private
        public void Hi()
        {
            Debug.Log("안녕하세요");
        }

        private void Bye()
        {
            Debug.Log("안녕히 계세요");
        }
    }
}
