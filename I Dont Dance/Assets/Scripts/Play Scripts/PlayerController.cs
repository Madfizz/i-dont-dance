using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    public float speed;

    public int freezeTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }

    // Could do that you pass in a wait time parameter from dancers?
    // Freeze the player when in contact with a dancer
    public void FreezePlayer()
    {
        StartCoroutine(FreezeCoroutine());
    }

    IEnumerator FreezeCoroutine()
    {
        yield return new WaitForSeconds(freezeTime);
    }


}
