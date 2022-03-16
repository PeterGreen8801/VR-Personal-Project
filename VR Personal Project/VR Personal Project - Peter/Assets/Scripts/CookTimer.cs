using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookTimer : MonoBehaviour
{
    public float spawnDelay = 5f;

    public bool isCounting = false;




    public void Go()
    {
        IEnumerator Wait()
        {
            //nextSpawnTime = Time.deltaTime + spawnDelay;
            isCounting = true;
            yield return new WaitForSeconds(spawnDelay);
            Debug.Log("Waited 5 seconds");
        }
        StartCoroutine(Wait());
        isCounting = false;
    }
}
