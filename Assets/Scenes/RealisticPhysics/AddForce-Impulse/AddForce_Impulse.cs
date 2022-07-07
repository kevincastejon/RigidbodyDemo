using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce_Impulse : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 10f;
    Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }
}
