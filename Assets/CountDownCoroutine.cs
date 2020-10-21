using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownCoroutine : MonoBehaviour
{
    Text displayText;
    float startTime = 3.0f;
    float lastTime;

    // Start is called before the first frame update
    void Start()
    {
        displayText = GetComponent<Text>();
        lastTime = startTime;
        StartCoroutine(CountDown());
    }

    // Update is called once per frame
    void Update()
    {
        //if(lastTime < 0.0f)
        //{
        //    displayText.text = "START";
        //    //START時の処理を入れる
        //}
        //else
        //{
        //    lastTime -= Time.deltaTime;
        //    float displayTime = Mathf.Ceil(lastTime);
        //    displayText.text = "開始" + displayTime.ToString("F0")+ "秒前";
        //}
    }
    IEnumerator CountDown()
    {   // コルーチン
        while (lastTime > 0)
        {
            float displayTime = Mathf.Ceil(lastTime);
            displayText.text = "開始" + displayTime.ToString("F0") + "秒前";
            yield return new WaitForSeconds(1.0f); //1秒待ち
            lastTime--;
        }
        displayText.text = "START";
        yield return null;
    }


}
