using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DeSpawnFromPool : MonoBehaviour
{

    //public CookTimer cook;

    /*
    void Update()
    {
        if (cook.isCounting == true)
        {
            Debug.Log("Read that bool is true");
            BasicPool.Instance.AddToPool(gameObject);
        }
    }*/

    /*
    void Start()
    {
        cook = GetComponent<CookTimer>();
    }
    */


    public void Despawn()
    {
        BasicPool.Instance.AddToPool(gameObject);
    }

    /*
    private void OnCollisionEnter(Collision collision)
    {
        BasicPool.Instance.AddToPool(gameObject);
    }
    */




    private void onSelectEnter()
    {
        BasicPool.Instance.AddToPool(gameObject);
        Debug.Log("On Select Enter Despawn");
    }

}
