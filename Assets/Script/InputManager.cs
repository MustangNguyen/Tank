using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    protected static InputManager instance;
    public static InputManager Instance { get => instance; }
    [SerializeField] protected Vector3 mouseWorldPos;
    public Vector2 MouseWorldPos { get => mouseWorldPos; }
    [SerializeField] protected float onFiring;
    void Awake()
    {
        instance = this;
    }
    private void FixedUpdate()
    {
        this.GetMousePos();
    }
    protected void GetMousePos()
    {
        this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    protected void GetMouseDown()
    {
        this.onFiring = Input.GetAxis("Fire1");
    }
}
