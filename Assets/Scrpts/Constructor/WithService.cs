using UnityEngine;

namespace Constructor
{
    public class WithService
    {
        //읽기전용(수정 불가능) 필드 생성
        private readonly string serviceName;

        //생성자 - 생성자에서는 읽기 전용 필드 초기화(할당, 대입) 가능
        public WithService()
        {
            serviceName = "파일";
        }

        public WithService(string _name)
        {
            serviceName = _name;
        }

        public void Run()
        {
            //serviceName = "File"; (x)
            Debug.Log($"{serviceName}를 실행합니다");
        }
    }
}
