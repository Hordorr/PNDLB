using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Camera = null;
    public float rotationSpeed;
    public float moveSpeed;
    private float yRotation;

    Rigidbody playerRigidbody;
    Transform playerTransform;
    void Start()
    {
        playerTransform = GetComponent<Transform>();
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
        Move();
    }

    void Rotation()
    {
       playerTransform.Rotate(new Vector3(0,Input.GetAxis("Mouse X"),0)*Time.deltaTime*rotationSpeed);      
       
       Camera.transform.Rotate(new Vector3 (-Input.GetAxis("Mouse Y"),0,0) * Time.deltaTime * rotationSpeed);       
       
    }
    void Move()
    {
        playerRigidbody.AddForce(playerTransform.forward * Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed);
    }
}
