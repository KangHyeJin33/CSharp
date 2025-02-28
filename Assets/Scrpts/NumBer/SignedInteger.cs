using UnityEngine;

public class SignedInteger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SignedIntege
        sbyte iSbyte = 127; //sbyte = (ũ���)8 Bit. ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ.
        short iInt16 = 32767;//ũ��� 16 Bit. ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ.
        int Iint32 = 2147483647; //ũ��� 32 Bit. ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ.
        long Iint64 = 9223372036845775807; //ũ��� 64 Bit. ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ.

        Debug.Log("sbyte : " + iSbyte);
        Debug.Log("short : " + iInt16);
        Debug.Log("int : " + Iint32);
        Debug.Log("long : " + Iint64);

        //UnSignedInteger
        byte iByte = 255; //ũ��� 8 Bit. ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ.
        ushort IUInt16 = 65535; //ũ��� 16 Bit. ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ.
        uint IUInt32 = 4294967295; //ũ��� 32 Bit. ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ.
        ulong IUInt64 = 18446744073709551615; //ũ��� 64 Bit. ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ.

        Debug.Log("byte : " + iByte);
        Debug.Log("ushort : " + IUInt16);
        Debug.Log("uint : " + IUInt32);
        Debug.Log("ulong : " + IUInt64);
    }

}

/*
1 Bit -> 0,1

1 Byte = 8 Bit(Byte�� Bit ��� 0~256���� ǥ�� ����. 0���� �����ؼ�)
0000 0000 -> 0 (0~255���� ǥ�� ����. 0���� ���������� 0�� �������� ����)
0000 0001 -> 1
0000 0010 -> 2
0000 0011 -> 3
0000 0100 -> 4
=> �� 8�ڸ�(256���� ����). 0�� 1�� ���� ����.

8 Bit
(+, -, 0)
sbyte : -128 ~ 127(128�� �ƴ� ������ �߰��� 0�� �־. -1���� -100����)

(+)
byte : 0(�ּ� ��) ~ 255(�ִ� ��)

 */

/*
SignedInteger (+, -) ��ȣ�� �ִ� ������ ������ ����(Ÿ��).
UnSignedInteger (+, -) ��ȣ�� ���� ������ ������ ����(Ÿ��).
 */

/* 
10���� : �ڸ��� �Ѿ�� 10�� �Ǵ� ���� 0�� ��.(15�� �����ϴ� 10������ F)
2���� : 2�� �Ǵ� ���� 1�� ��.
*/
