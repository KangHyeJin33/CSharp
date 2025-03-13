using System.Collections;
using UnityEngine;

public class QueueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] Queue클래스의 인스턴스(객체, 개체) 생성
        Queue queue = new Queue();

        //[2] Queue에 데이터 입력(Enqueue) 
        queue.Enqueue(10); // 입구로 들어와서 출구 첫번 째부터 쌓인다.
        queue.Enqueue(20);
        queue.Enqueue(30);

        //[3] Queue에 데이터 꺼내기(Dequeue) - 출구쪽의 맨 앞에 있는 데이터를 꺼낸다
        Debug.Log(queue.Dequeue()); 
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());

    }
}

/*
Queue 클래스 : FIFO(First In First Out) 형태로 데이터를 저장 관리하는 클래스
- FIFO(First In First Out) : 선입선출. 가장 먼저 데이터를 입력하면 가장 먼저 출력한다(나온다). 터널형 데이터 창고 구조. 대기표.

Enqueue() : 큐에 데이터 입력
Dequeue() : 큐에 데이터 꺼내기

 */