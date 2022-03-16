using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawn : MonoBehaviour
{
    [Tooltip("Time before destroying in seconds")]
    public float lifeTime = 5f;

    public bool destroy = true;

    public GameObject Prefab;

    public float spawnDelay = 5f;

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

        //var prefabInstance = Instantiate(Prefab, Prefab.transform.position, Quaternion.identity);
        //Destroy(prefabInstance);

        /*
        Prefab = GameObject.FindGameObjectsWithTag("uncooked");
        foreach (GameObject uncookedPatty in Prefab)
        {
            Destroy(GameObject.FindGameObjectWithTag("uncooked"), lifeTime);
        }
        */


        //Destroy(GameObject.FindGameObjectWithTag("uncooked"));

        IEnumerator Wait()
        {

            yield return new WaitForSeconds(spawnDelay);
            Destroy(GameObject.FindGameObjectWithTag("uncooked"));
        }
        StartCoroutine(Wait());
    }
}
