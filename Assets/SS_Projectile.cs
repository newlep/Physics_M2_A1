using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SS_Projectile : MonoBehaviour
{

    public GameObject Shakdart_Radius;

   private void OnCollisionEnter(Collision enemy)
   {
     Instantiate(Shakdart_Radius, transform.position, Quaternion.identity);
      

    

    Destroy(gameObject);



   }

}
