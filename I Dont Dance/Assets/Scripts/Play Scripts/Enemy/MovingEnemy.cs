using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : BaseEnemy
{
    private Vector3 direction = Vector3.forward;

    public float speed;

    //public MovingEnemy(Vector3 dir)
    //{
        //direction = dir;
    //}

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    protected override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            ChangeDirection();
        }

        base.OnTriggerEnter(other);
    }

    private void ChangeDirection()
    {
        direction = -direction;
    }
}
