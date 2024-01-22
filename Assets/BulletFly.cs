using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : MonoBehaviour
{
    [SerializeField] protected float moveSpeed = 1.0f;
    [SerializeField] protected Vector3 direction= Vector3.up;
    private void Update()
    {
        transform.Translate(this.direction*moveSpeed*Time.deltaTime);
    }
}
