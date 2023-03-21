using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    Observer observer;
    // Start is called before the first frame update
    void Start()
    {
        observer = GameObject.Find("Observer").GetComponent<Observer>();
        observer.ResetValueAndAnswer();
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    
}
