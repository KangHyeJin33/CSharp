using UnityEngine;

//[1] �켱������ �����ϴ� ������ ����(����, �����)
//����� ���� ������ ����.
enum Priorty
{
    High, // ����� ����. 0. (High�� ���콺 ���ٴ�� ����)
    Norma, // 1
    Low, // 2
}

public class EnumDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] ������ ���� ���� �� �ʱ�ȭ
        //������ ������ ����Ǵ� ���� ���ǿ��� ������� ��� ���� �����ϴ�.
        Priorty high = Priorty.High;
        Priorty norma = Priorty.Norma;
        Priorty low = Priorty.Low;

        Debug.Log($"{high}, {norma}, {low}");
    }
}

/*
Enumeration(������) : �ϳ��� �̸����� ���� �����ִ� �������� ���� ������� ����.

// ����
enum (enum �̸�)
{
    �����,
    �����,
    �����,
    ...
}

 */