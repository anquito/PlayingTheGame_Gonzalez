using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float forSpeed;
    private GameObject focalPoint;
    private Renderer playerRend;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRend = GetComponent<Renderer>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * verticalInput * forSpeed);
        if(verticalInput > 0)
        {
            playerRend.material.color = new Color(1 - verticalInput, 1, 1 - verticalInput);
        }
        else
        {
            playerRend.material.color = new Color(1 + verticalInput, 1, 1 + verticalInput);
        }
    }
}
