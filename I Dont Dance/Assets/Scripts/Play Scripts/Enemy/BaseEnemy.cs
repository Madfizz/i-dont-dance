using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{
    public static int lifeSpan = 7;

    protected virtual void Start()
    {
        // Enemy dancers only last for a number of seconds
        StartCoroutine(InitiateLifeSpan());
    }
    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().FreezePlayer();
            StopCoroutine(InitiateLifeSpan());
            StopDancing();
        }
    }

    protected virtual void StopDancing()
    {
        Destroy(gameObject);
    }

    IEnumerator InitiateLifeSpan()
    {
        yield return new WaitForSeconds(lifeSpan);
        StopDancing();
    }
}
