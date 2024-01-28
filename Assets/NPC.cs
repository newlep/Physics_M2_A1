using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour


{
    public float AISpeed;
    public Transform AIthingy;
    void Update()
    
    
    {
        AIthingy.position += new Vector3(-AISpeed*Time.deltaTime, 0, 0);
        


    }
    private void OnCollisionEnter(Collision enemy)
   {
      if (enemy.gameObject.tag == "Player")
      {
         Destroy(enemy.gameObject);
      }

    if (enemy.gameObject.tag == "Bullet")
    {
        AudioManager.instance.Play("Hit");
    }

   }


}
