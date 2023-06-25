using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        var time = _speed * Time.deltaTime;
        var position = gameObject.transform.position;
        Debug.Log(position);
        if (Input.GetKey(KeyCode.W))
        {
             position.z += time;
             transform.position = position;
        }
        if (Input.GetKey(KeyCode.S))
        {
            position.z -= time;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.A))
        {
            position.x -= time;
            transform.position = position;
        }
        if (Input.GetKey(KeyCode.D))
        {
            position.x += time;
            transform.position = position;
        }
        Debug.Log(position);

    }
}
