using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawn : MonoBehaviour
{
    [Tooltip("Time before destroying in seconds")]
    public float lifeTime = 2.0f;

    public bool destroy = true;

    public GameObject Prefab;


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
        //Destroy(this.gameObject.transform);

        //Destroy(this.gameObject);
        //GameObject a = Instantiate(this.gameObject, this.gameObject.transform.position, Quaternion.identity);
        //Destroy(a);

        var prefabInstance = Instantiate(Prefab, Prefab.transform.position, Quaternion.identity);
        Destroy(prefabInstance);
        Destroy(GameObject.FindGameObjectWithTag("uncooked"));
    }
}
