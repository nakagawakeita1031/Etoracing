using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField, Tooltip("時間計測用")]
    private float timer;

    [SerializeField, Header("ゲーム時間設定")]
    private int goalTime;

    //クリア判定。60秒たったらtrueになる
    private bool clear = false;

    [SerializeField]
    private Text textGoalTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (clear == false)
        {
            //60秒でゲーム終了
            timer += Time.deltaTime;

            //もしtimerが1秒経過したら再カウントする
            if (timer >= 1.0f)
            {
                timer = 0;
                goalTime--;

                //ゴールタイムが0秒以下になった場合timerを止める
                if (goalTime <= 0)
                {
                    clear = true;

                    SceneManager.LoadScene("Result");
                    Debug.Log("ゲームクリア状態");
                }

                //残り時間表示更新
                textGoalTime.text = goalTime.ToString();

                

            }
        }
    }
}
