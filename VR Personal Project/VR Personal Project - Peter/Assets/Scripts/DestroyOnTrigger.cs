using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public GameObject objToDestroy;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Grill")
        {
            var clone = Instantiate(objToDestroy, transform.position, Quaternion.identity);
            Destroy(clone);
        }
    }

    public void Destroy()
    {
        var clone = Instantiate(objToDestroy, transform.position, Quaternion.identity);
        Destroy(clone);
    }

}
