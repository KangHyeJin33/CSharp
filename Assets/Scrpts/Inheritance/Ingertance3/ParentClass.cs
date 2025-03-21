//using UnityEngine;
using System;

namespace Inheritance 
{
    public class ParentClass : Object
{
        public static void Hi() => UnityEngine.Debug.Log("안녕하세요"); //'Inheritance : object ' -> Degug 에러 : 생략이 가능해서 비활성화 됨
    }
}

