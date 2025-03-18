using System;
using UnityEngine;

public class NullDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // null 가능 형식
        //bool bln = null; //bool은 값형식이라 null값은 사용할 수 없음.
        Nullable<bool> bln = null; //해당 bool형은 null값 사용 가능함.
        Debug.Log(bln.HasValue); //값이 있으면 true, 없으면 false.
        bln = false;
        Debug.Log(bln.HasValue); //  false 값을 갖고 있어서 True.

        //Nullable<int> -> int? // null이 가능한 int
        //Nullable<float> -> float? // null이 가능한 float
        //Nullable<int> ni = null;
        int? ni = null;
        ni = 10;
        Debug.Log(ni);


    }
}
