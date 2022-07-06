using UnityEngine;
using UnityEngine.Events; // 必要！

public class Timer
{
    public UnityEvent onComplete = new UnityEvent();

    public void CountDown()
    {
        // 本当はちゃんと3秒かけてカウントする
        Debug.Log(3);
        Debug.Log(2);
        Debug.Log(1);

        // コールバック
        onComplete.Invoke();
    }
}
