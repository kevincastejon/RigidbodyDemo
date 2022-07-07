using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce_Force : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    Vector3 _direction;
    Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
    }
    private void FixedUpdate()
    {
        _rigidbody.AddForce(_direction * _speed, ForceMode.Force);
    }
}
