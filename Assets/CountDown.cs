using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    Text displayText;
    float startTime = 3.0f;
    float lastTime;

    // Start is called before the first frame update
    void Start()
    {
        displayText = GetComponent<Text>();
        lastTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(lastTime < 0.0f)
        {
            displayText.text = "START";
            //START時の処理を入れる
        }
        else
        {
            lastTime -= Time.deltaTime;
            float displayTime = Mathf.Ceil(lastTime);
            displayText.text = "開始" + displayTime.ToString("F0")+ "秒前";
        }
    }
}
