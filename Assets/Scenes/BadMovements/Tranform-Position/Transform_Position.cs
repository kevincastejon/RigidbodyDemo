using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_Position : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        _transform.position += direction * _speed * Time.deltaTime;
    }
}
