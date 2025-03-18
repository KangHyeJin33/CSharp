using PrivatePulic;
using UnityEngine;

namespace PrivatePulic
{
    public class FieldArray : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Schedule 클래스의 인스턴스(객체) 생성
            Schedule schedule = new Schedule();
            schedule.PrintWeekDays();
        }
    }
}