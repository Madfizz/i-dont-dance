using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingEnemy : BaseEnemy
{
    private PlayerController player;

    private Vector3 playerDir;

    public float speed;

    protected override void Start()
    {
        base.Start();
        player = FindObjectOfType<PlayerController>();

    }
    private void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        playerDir = player.transform.position - transform.position;
        gameObject.transform.Translate(playerDir.normalized * speed * Time.deltaTime);
    }
}
