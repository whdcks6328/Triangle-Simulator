using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    Observer observer;


    public void Calculater()
    {
        /*observer = GameObject.Find("Observer").GetComponent<Observer>();
        if (observer.isSAS)
        {
            float bSinC = float.Parse(observer.secondInfo) * Mathf.Sin(float.Parse(observer.firstInfo) * Mathf.Deg2Rad);
            float abCosC = float.Parse(observer.aSide) - float.Parse(observer.secondInfo) * Mathf.Cos(float.Parse(observer.firstInfo) * Mathf.Deg2Rad);
            observer.answerA = Mathf.Sqrt(bSinC * bSinC  + abCosC * abCosC);
        }
        else
        {
            float sinA = Mathf.Sin(Mathf.Deg2Rad * (180f - float.Parse(observer.secondInfo) - float.Parse(observer.firstInfo)));
            float asinB = float.Parse(observer.aSide) * Mathf.Sin(Mathf.Deg2Rad * float.Parse(observer.firstInfo));
            float asinC = float.Parse(observer.aSide) * Mathf.Sin(Mathf.Deg2Rad *float.Parse(observer.secondInfo));
            observer.answerA = asinC / sinA;
            observer.answerB = asinB / sinA;
        }*/
    }
    public void ResetTrigger()
    {
        observer = GameObject.Find("Observer").GetComponent<Observer>();
        observer.ResetValueAndAnswer();
    }
    public void ExitButtonTrigger()
    {
        Application.Quit();
    }
}
