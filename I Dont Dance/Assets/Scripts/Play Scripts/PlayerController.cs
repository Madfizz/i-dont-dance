using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject camCentrePoint;

    public float playerSpeed;
    public float camRotSpeed;

    public int freezeTime;

    private float horizontalInput;
    private float verticalInput;
    private float horizontalCamInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Abstraction
        MoveCamera();
        MovePlayer();
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
        Debug.Log("Freeze!");
    }

    // Abstraction
    private void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(camCentrePoint.transform.forward * verticalInput * playerSpeed * Time.deltaTime);
        transform.Translate(camCentrePoint.transform.right * horizontalInput * playerSpeed * Time.deltaTime);
    }

    private void MoveCamera()
    {
        horizontalCamInput = Input.GetAxis("HorizontalArrows");

        camCentrePoint.transform.Rotate(Vector3.up, -horizontalCamInput * camRotSpeed * Time.deltaTime);
    }

    public void ActivatePowerUp()
    {

    }
}
