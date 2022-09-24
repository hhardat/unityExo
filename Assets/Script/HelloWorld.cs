using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField ]private string message;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log(message);
    }
}
