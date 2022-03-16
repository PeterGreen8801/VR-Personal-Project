using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagChanger : MonoBehaviour
{
    public GameObject Prefab;

    void Start()
    {
        Prefab.gameObject.tag = "nothing";
        Debug.Log(Prefab.gameObject.tag + ": Tag was changed to");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Grill")
        {
            Prefab.gameObject.tag = "uncooked";
            Debug.Log(Prefab.gameObject.tag + ": Tag was changed to");
        }
    }
}
