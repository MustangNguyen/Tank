using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting : MonoBehaviour
{
    [SerializeField] protected float isShooting = 0;
    [SerializeField] protected Transform bullet;
    [SerializeField] protected Vector3 targetPosition;
    [SerializeField] protected float bulletSpeed = 10f;
    private void FixedUpdate()
    {
        this.Shooting();
    }
    protected void Shooting()
    {
        this.isShooting = Input.GetAxis("Fire1");
        if (isShooting==0) return;
        Instantiate(this.bullet);
        bullet.transform.Translate(targetPosition * bulletSpeed * Time.deltaTime);
    }
    protected void GetTargetPos()
    {
        this.targetPosition = InputManager.Instance.MouseWorldPos;
        this.targetPosition.z = 0;
    }
    protected void LookAtTarget()
    {
        Vector3 diff = this.targetPosition - transform.parent.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z + 90);
    }
}
