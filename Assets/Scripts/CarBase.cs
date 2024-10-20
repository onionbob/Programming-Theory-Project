using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBase : MonoBehaviour
{
    [SerializeField] protected float speed = 10f;
    [SerializeField] protected float rotationSpeed = 5f;
    [SerializeField] GameObject centerOfMass;

    protected Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRb.AddRelativeForce(Vector3.forward * verticalInput * speed);
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * rotationSpeed);
        //playerRb.AddRelativeTorque(Vector3.up * Time.deltaTime * horizontalInput * rotationSpeed);
    }
}
