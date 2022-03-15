using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;

    public float nextSpawnTime;
    public float spawnDelay = 5f;

    public void Spawn()
    {
        if (shouldSpawn())
        {
            IEnumerator Wait()
            {
                //nextSpawnTime = Time.deltaTime + spawnDelay;
                yield return new WaitForSeconds(spawnDelay);
                Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
            }
            StartCoroutine(Wait());
        }
    }

    private bool shouldSpawn()
    {
        return Time.time > nextSpawnTime;
    }

    /*
    void OnTriggerEnter()
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
    }
    */
}
