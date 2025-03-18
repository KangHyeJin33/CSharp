using UnityEngine;

//정적(static, shared) 멤버와 인스턴스 멤버
//[1] 클래스 선언
public class ShardAndInstance
{
    //static 멤버 메서드
    public static void StaticMember() => Debug.Log("[1] Static Member"); // 정적멤버

    // instance 멤버 메서드
    public void InstanceMember() => Debug.Log("[2] Instance Member"); // 인스턴스 멤버
}
public class StaticAndInstans : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ShardAndInstance 클래스 사용
        //[1] 정적멤버 사용 : '클래스이름.멤버이름' 으로 호출
        ShardAndInstance.StaticMember();

        //[2] 인스턴스 멤버 사용 : '개체이름.멤버이름' 으로 호출
        ShardAndInstance obj = new ShardAndInstance(); // obj -> 오브젝트 이름
        obj.InstanceMember();
    }
}
