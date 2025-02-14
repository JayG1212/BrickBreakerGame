// . 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] protected float worldVelocity = 25;
    [SerializeField] protected Vector3 startForce = Vector3.one;
    [SerializeField] protected int damage = 1;
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();

        ApplyStartForce();
    }
    private void FixedUpdate()
    {
        LimitBallVelocity();
    }

    protected void ApplyStartForce()
    {
        rb.AddForce(startForce, ForceMode.Impulse);
    }

    protected void LimitBallVelocity()
    {
        Vector3 hv3 = rb.velocity;

        Vector3 nv3 = Vector3.zero;

        nv3.x = Mathf.Clamp(hv3.x, -worldVelocity, worldVelocity);
        nv3.y = Mathf.Clamp(hv3.y, -worldVelocity, worldVelocity);
        nv3.z = Mathf.Clamp(hv3.z, -worldVelocity, worldVelocity);
        rb.velocity = nv3;
    }
    private void OnCollisionEnter(Collision collision)
    {
       BreakableBrick brick = collision.gameObject.GetComponent<BreakableBrick>();
        if(brick != null)
        {
            brick.Break(damage);
        }
    }
}
