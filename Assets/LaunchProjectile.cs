using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public Transform LaunchPoint;
    public GameObject projectile;
    public GameObject S_Projectile;
    public GameObject SS_Projectile;
    public float power = 15;
    public float launchVelocity = 0;
    public float maxVelocity = 20;



    void Update()
    {

          if(Input.GetKey(KeyCode.Q))
    
    {

        launchVelocity+=power* Time.deltaTime;

        if(launchVelocity >= maxVelocity)
        {

            launchVelocity = maxVelocity;
        }
        
        }

        if(Input.GetKeyUp(KeyCode.Q))

        {
            var _projectile = Instantiate(S_Projectile, LaunchPoint.position, LaunchPoint.rotation);
        _projectile.GetComponent<Rigidbody>().velocity = LaunchPoint.up * launchVelocity;

            launchVelocity = 0;            

        }



        if(Input.GetButton("Jump"))
    
    {

        launchVelocity+=power* Time.deltaTime;

        if(launchVelocity >= maxVelocity)
        {

            launchVelocity = maxVelocity;
        }
    }
        if(Input.GetButtonUp("Jump"))

        {
            var _projectile = Instantiate(projectile, LaunchPoint.position, LaunchPoint.rotation);
        _projectile.GetComponent<Rigidbody>().velocity = LaunchPoint.up * launchVelocity;

            launchVelocity = 0;

        }

    
          if(Input.GetKey(KeyCode.E))
    
    {

        launchVelocity+=power* Time.deltaTime;

        if(launchVelocity >= maxVelocity)
        {

            launchVelocity = maxVelocity;
        }
        
        }

        if(Input.GetKeyUp(KeyCode.E))

        {
            var _projectile = Instantiate(SS_Projectile, LaunchPoint.position, LaunchPoint.rotation);
        _projectile.GetComponent<Rigidbody>().velocity = LaunchPoint.up * launchVelocity;

            launchVelocity = 0;            

        }


    }
}
