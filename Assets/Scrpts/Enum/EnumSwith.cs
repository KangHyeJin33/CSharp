using UnityEngine;

//�������� switch���� �Բ� ���� ���Ǿ�����.
//�ѱ� ���� �̸� ����ϱ�
enum Animalw
{
    Chicken,
    Dog,
    Pig
}

public class EnumSwith : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //������ ���� ���� �� �ʱ�ȭ
        Animalw ani = Animalw.Dog;
        PringAnimal(ani);

    }

    //�Ű������� ������ ������ �޾� �ѱ� �̸� ����ϱ�
    void PringAnimal(Animalw animal)
    {
        switch(animal)
        {
            case Animalw.Chicken :
                Debug.Log("��");
                break;
            case Animalw.Dog:
                Debug.Log("������");
                break;
            case Animalw.Pig:
                Debug.Log("����");
                break;

        }
        
    }
}
