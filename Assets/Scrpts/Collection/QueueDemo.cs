using System.Collections;
using UnityEngine;

public class QueueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] QueueŬ������ �ν��Ͻ�(��ü, ��ü) ����
        Queue queue = new Queue();

        //[2] Queue�� ������ �Է�(Enqueue) 
        queue.Enqueue(10); // �Ա��� ���ͼ� �ⱸ ù�� °���� ���δ�.
        queue.Enqueue(20);
        queue.Enqueue(30);

        //[3] Queue�� ������ ������(Dequeue) - �ⱸ���� �� �տ� �ִ� �����͸� ������
        Debug.Log(queue.Dequeue()); 
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());

    }
}

/*
Queue Ŭ���� : FIFO(First In First Out) ���·� �����͸� ���� �����ϴ� Ŭ����
- FIFO(First In First Out) : ���Լ���. ���� ���� �����͸� �Է��ϸ� ���� ���� ����Ѵ�(���´�). �ͳ��� ������ â�� ����. ���ǥ.

Enqueue() : ť�� ������ �Է�
Dequeue() : ť�� ������ ������

 */