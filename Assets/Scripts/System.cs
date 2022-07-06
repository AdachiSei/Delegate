using UnityEngine;

public class System : MonoBehaviour
{
    Timer _timer;

    void Start()
    {
        _timer = new Timer();//参照       
        _timer.CountDown();//実行
    }

    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            _timer.onComplete.AddListener(Alarm);//代入
            _timer.CountDown();//実行

        }
    }

    void Alarm()
    {
        Debug.Log("カウントダウン終了");
    }
}
