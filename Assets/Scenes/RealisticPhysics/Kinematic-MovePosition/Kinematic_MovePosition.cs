using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kinematic_MovePosition : MonoBehaviour
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
        _rigidbody.MovePosition(_rigidbody.position + _direction * _speed * Time.deltaTime);
    }
}
