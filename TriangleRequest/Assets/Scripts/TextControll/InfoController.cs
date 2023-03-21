using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoController : MonoBehaviour
{
    Observer observer;
    Text text;
    Vector3 leftAngle, rightAngle, leftSide;
    RectTransform rect;
    private void Start()
    {
        observer = GameObject.Find("Observer").GetComponent<Observer>();
        text = GetComponent<Text>();
        rect = GetComponent<RectTransform>();
        leftAngle = new Vector3(-100f+720f, -150f+1480f, 0f);
        rightAngle = new Vector3(250f+720f, -150f+1480f, 0f);
        leftSide = new Vector3(-400f+720f, 250f+1480f, 0f);
    }


    // Update is called once per frame
    void Update()
    {
        /*if(gameObject.name.Contains("Info 1"))
        {
            if (observer.isSAS)
            {
                rect.SetPositionAndRotation(leftAngle, Quaternion.Euler(Vector3.zero));
            }
            else
            {
                rect.SetPositionAndRotation(rightAngle, Quaternion.Euler(Vector3.zero));
            }
        }
        else
        {
            if (observer.isSAS)
            {
                rect.SetPositionAndRotation(leftSide, Quaternion.Euler(Vector3.zero));
            }
            else
            {
                rect.SetPositionAndRotation(leftAngle, Quaternion.Euler(Vector3.zero));
            }
        }*/
    }
}
