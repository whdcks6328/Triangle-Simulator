using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerController : MonoBehaviour
{
    Observer observer;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        observer = GameObject.Find("Observer").GetComponent<Observer>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.name.Contains("Value"))
        {
            if (this.gameObject.name.Contains("b"))
            {
                //text.text = observer.answerB.ToString();
            }
            else
            {
                //text.text = observer.answerA.ToString();
            }
        }
    }
}
