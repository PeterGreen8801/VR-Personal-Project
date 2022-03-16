using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketTagChanger : MonoBehaviour
{
    public GameObject Prefab;

    void Start()
    {
        Prefab.gameObject.tag = "nothing";
        Debug.Log("Prefab: " + Prefab + " " + Prefab.gameObject.tag + ": Tag was changed to");
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "nothing")
        {
            Prefab.gameObject.tag = "uncooked";
            Debug.Log("Prefab: " + Prefab + " " + Prefab.gameObject.tag + ": Tag was changed to");
        }
    }
}
