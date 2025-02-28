using UnityEngine;

public class SignedInteger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SignedIntege
        sbyte iSbyte = 127; //sbyte = (크기는)8 Bit. 부호가 있는 정수형 변수 선언 및 초기화.
        short iInt16 = 32767;//크기는 16 Bit. 부호가 있는 정수형 변수 선언 및 초기화.
        int Iint32 = 2147483647; //크기는 32 Bit. 부호가 있는 정수형 변수 선언 및 초기화.
        long Iint64 = 9223372036845775807; //크기는 64 Bit. 부호가 있는 정수형 변수 선언 및 초기화.

        Debug.Log("sbyte : " + iSbyte);
        Debug.Log("short : " + iInt16);
        Debug.Log("int : " + Iint32);
        Debug.Log("long : " + Iint64);

        //UnSignedInteger
        byte iByte = 255; //크기는 8 Bit. 부호가 없는 정수형 변수 선언 및 초기화.
        ushort IUInt16 = 65535; //크기는 16 Bit. 부호가 없는 정수형 변수 선언 및 초기화.
        uint IUInt32 = 4294967295; //크기는 32 Bit. 부호가 없는 정수형 변수 선언 및 초기화.
        ulong IUInt64 = 18446744073709551615; //크기는 64 Bit. 부호가 없는 정수형 변수 선언 및 초기화.

        Debug.Log("byte : " + iByte);
        Debug.Log("ushort : " + IUInt16);
        Debug.Log("uint : " + IUInt32);
        Debug.Log("ulong : " + IUInt64);
    }

}

/*
1 Bit -> 0,1

1 Byte = 8 Bit(Byte와 Bit 모두 0~256까지 표현 가능. 0부터 시작해서)
0000 0000 -> 0 (0~255까지 표현 가능. 0부터 시작하지만 0은 포함하지 않음)
0000 0001 -> 1
0000 0010 -> 2
0000 0011 -> 3
0000 0100 -> 4
=> 총 8자리(256까지 가능). 0과 1만 대입 가능.

8 Bit
(+, -, 0)
sbyte : -128 ~ 127(128이 아닌 이유는 중간에 0이 있어서. -1부터 -100까지)

(+)
byte : 0(최소 값) ~ 255(최대 값)

 */

/*
SignedInteger (+, -) 부호가 있는 정수형 데이터 형식(타입).
UnSignedInteger (+, -) 부호가 없는 정수형 데이터 형식(타입).
 */

/* 
10진수 : 자리가 넘어가면 10이 되는 순간 0이 됨.(15를 포현하는 10진수는 F)
2진수 : 2가 되는 순간 1이 됨.
*/
