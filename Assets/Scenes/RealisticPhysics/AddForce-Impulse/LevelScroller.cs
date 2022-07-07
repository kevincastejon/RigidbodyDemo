using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScroller : MonoBehaviour
{
    [SerializeField] private float _scrollSpeed = 3f;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + Vector3.left * _scrollSpeed * Time.deltaTime);
    }
}
