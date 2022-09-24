using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        Jump();
        Fire();
        Move();
    }

    private void Fire()
    {
        if (Input.GetButton("Fire1")) Debug.Log("Fire");
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump")) Debug.Log("Jump");
    }

    private void Move()
    {
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        var newPos = transform.position;
        newPos += dir * Time.deltaTime * speed;
        transform.position = newPos;       
    }
}
