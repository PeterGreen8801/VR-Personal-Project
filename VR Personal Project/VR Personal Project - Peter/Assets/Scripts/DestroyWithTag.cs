using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithTag : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject burgerToDestroy;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Destroy()
    {
        burgerToDestroy = GameObject.FindGameObjectWithTag("uncooked");
        Object.Destroy(burgerToDestroy);
    }
}
