using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculater : MonoBehaviour
{
    Observer observer;
    // Start is called before the first frame update
    void Start()
    {
        observer = GameObject.Find("Observer").GetComponent<Observer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
