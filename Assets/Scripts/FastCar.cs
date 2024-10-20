using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastCar : CarBase
{
    [SerializeField] float itemBoostSpeed = 100;
    [SerializeField] int boostCooldown = 5;

    float cooldownCounter = 0;

    // Update is called once per frame
    void LateUpdate()
    {
        if (cooldownCounter >= boostCooldown)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerRb.AddRelativeForce(Vector3.forward * itemBoostSpeed, ForceMode.Impulse);
                cooldownCounter = 0;
            }
            else
                cooldownCounter = boostCooldown;            
        }
        
        cooldownCounter += Time.deltaTime;
    }
}
