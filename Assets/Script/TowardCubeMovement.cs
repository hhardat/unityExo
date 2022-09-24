using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowardCubeMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        var newPos = transform.position;
        newPos += (target.position - newPos).normalized * Time.deltaTime * speed;
        transform.position = newPos;
    }
}
