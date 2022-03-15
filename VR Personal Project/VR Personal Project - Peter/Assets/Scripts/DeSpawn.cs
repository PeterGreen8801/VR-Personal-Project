using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawn : MonoBehaviour
{
    [Tooltip("Time before destroying in seconds")]
    public float lifeTime = 2.0f;

    public bool destroy = true;


    public void Go()
    {
        Destroy(this.gameObject);

    }

    public void SetActive()
    {
        this.gameObject.SetActive(false);
    }

    public void Despawn()
    {
        Destroy(this.gameObject.transform);
    }
}
