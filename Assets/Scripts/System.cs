using UnityEngine;

public class System : MonoBehaviour
{
    void Start()
    {
        Timer timer = new Timer();
        timer.onComplete.AddListener(Alarm);
        timer.CountDown();
    }

    void Alarm()
    {
        Debug.Log("カウントダウン終了");
    }
}
