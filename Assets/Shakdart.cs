using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Shakdart : MonoBehaviour
{

    public float GrowthRate;
    public float MaxSize;


    void OnTriggerEnter(Collider col)
    {


        if(col.transform.CompareTag("Enemy"))
        {
            Destroy(col.gameObject);

        }
    }

    void Update()
    {

        transform.localScale+=new Vector3(transform.localScale.x * Time.deltaTime * GrowthRate, transform.localScale.y * Time.deltaTime * GrowthRate, transform.localScale.z * Time.deltaTime * GrowthRate);
        if(transform.localScale.x >= MaxSize)
        {

            Destroy(gameObject);

        }

    }
}
