using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed = 3;
    private Vector3 _direction;

    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        var speed = _direction * _speed * Time.fixedDeltaTime;
        transform.Translate(speed);
    }
}
