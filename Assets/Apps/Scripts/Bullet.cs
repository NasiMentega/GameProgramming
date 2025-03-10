using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IPoolObject
{
    [SerializeField] private float speed = 10f;
    private Vector2 direction;

    void Update()
    {
        transform.position += (Vector3)direction * speed * Time.deltaTime;
    }

    public void Activate()
    {
        gameObject.SetActive(true);
    }

    public void Deactivate()
    {
        gameObject.SetActive(false);
    }

    internal void SetPosition(Vector3 position)
    {
        transform.position = position;
    }

    internal void SetRotation(Quaternion rotation)
    {
        transform.rotation = rotation;
    }

    public void SetDirection(Vector2 newDirection)
    {
        direction = newDirection.normalized;
    }
}
