using TMPro;
using UnityEngine;

namespace Inheritance11
{
    //부모 클래스
    public class BaseClass
    {
        //필드 - 기본적으로 private으로 설정. 외부에서 접근 불가능.
        private string word;

        //속성 - BaseClass를 상속받은 자식 클래스에서만 접근 가능하도록 설정
        protected string Word //Word : 밑에 자식클래스에서 접근하여 값을 저장함.
        {
            get { return word; }
            set { word = value; }
        }
    }
    //(BaseClass를 상속받는) 자식 클래스 
    public class SubClass : BaseClass
    {
        public void SetWord(string _word)
        {
            base.Word = _word; //Word값에 들어온 _word값 저장.
        }

        public string GetWord()
        {
            return base.Word;
        }
            
    }
}
