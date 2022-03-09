using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawn : MonoBehaviour
{
    [Tooltip("Time before destroying in seconds")]
    public float lifeTime = 5.0f;


    public void Despawn()
    {
        Destroy(gameObject, lifeTime);
    }
}
