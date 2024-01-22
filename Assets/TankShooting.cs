using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting : MonoBehaviour
{
    [SerializeField] protected float isShooting = 0;
    [SerializeField] protected Transform bullet;
    [SerializeField] protected Vector3 targetPosition;
    private void FixedUpdate()
    {
        GetTargetPos();
        this.Shooting();
    }
    protected void Shooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 spawPos = transform.position;
            Quaternion rotation = transform.parent.rotation;
            Quaternion rotatedQuaternion = Quaternion.Euler(0, 0, -90) * rotation;

            Instantiate(this.bullet, spawPos, rotatedQuaternion);

        }
    }
    protected void GetTargetPos()
    {
        this.targetPosition = InputManager.Instance.MouseWorldPos;
        this.targetPosition.z = 0;
    }  
}
