using UnityEngine;

// �ȳ��ϼ��並 3�� ����ϴ� ���α׷�.
public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*for(int i=0; i< 3; i++)
       {
           // �ݺ����๮
           Debug.Log("�ȳ��ϼ���");
       }*/

        /*[1] �ʱ��
        int i = 0;

        while (i < 3) //[2]���ǽ�
        {
            //�ݺ� ���๮.
            Debug.Log("�ȳ��ϼ���.");

            //������
            i++; 
        }*/

        //do while
        //[1] �ʱ��
        int i = 0;

        do
        {
            //�ݺ� ���๮.
            Debug.Log("�ȳ��ϼ���");
            //������.
            i++;
        } while (i < 3); //[3] ���ǽ�

        // i = 0; -> ��� -> ������(i++ = i(0)+1 = 1) -> i < 3 (��) -> ��� ->
        // ������(i++ = i(1)+1 = 2) -> i < 3 (��) -> ��� -> ������(i++ = i(2)+1 = 3) -> i < 3 (����) -> do while�� ����.
    }
}
/*
< do while > : �ݺ���.
[!] ����, �ݺ� ���๮�� 1�� �����Ѵ�.
- ���ǽ��� true�� �ݺ����� �����Ѵ�.
- ���ǽ��� false�� while���� �����Ѵ�.

do
{
    //�ݺ� ���๮.

} while(���ǽ�)


 */