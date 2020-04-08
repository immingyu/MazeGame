using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public float T;

    public Text text_Timer;
    public Text score1;
    public Text score2;
    public Text score3;

    public bool start;
    public bool end;

    public int count;
    public float[] data=new float[3];
    public float tmp;

    void Start()
    {
        T = 0;
        count = 0;
        start = false;
        end = false;
        score1.text = "score1 : 0";
        score2.text = "score2 : 0";
        score3.text = "score3 : 0";
        //score1.text = "score1 : " + PlayerPrefs.GetFloat("score1").ToString();
        //score2.text = "score2 : " + PlayerPrefs.GetFloat("score2").ToString();
        //score3.text = "score3 : " + PlayerPrefs.GetFloat("score3").ToString();
        data[0] = 0;
        data[1] = 0;
        data[2] = 0;
    }

    void Update()
    {
        text_Timer.text = "시간 :" + Mathf.Round(T);
        //if (start ==true && count < 3)
        if (start == true)
        {
            if (end == false)
            {
                T += Time.deltaTime;
            }
            else
            {
                //T를 data와의 비교후 넣기
                if (T > data[0])
                {
                    data[0] = T;
                }
                //data 큰거부터 정렬
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (data[i] < data[j])
                        {
                            tmp = data[i];
                            data[i] = data[j];
                            data[j] = tmp;

                        }
                    }
                }
                T = 0;
                start = false;
                end = false;

            }
                PlayerPrefs.SetFloat("score1", data[0]);
                score1.text = "score1 : " + PlayerPrefs.GetFloat("score1").ToString();
                PlayerPrefs.SetFloat("score2", data[1]);
                score2.text = "score2 : " + PlayerPrefs.GetFloat("score2").ToString();
                PlayerPrefs.SetFloat("score3", data[2]);
                score3.text = "score3 : " + PlayerPrefs.GetFloat("score3").ToString();
                //count++;
                //T = 0;
                //start = false;
                //end = false;
        }
        }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "start")
        {
            Debug.Log("시작");
            start = true;
        }
        else if (collision.gameObject.name == "end")
        {
            if (start == true)
            {
                Debug.Log("종료");
                end = true;
            }
        }
    }
}
