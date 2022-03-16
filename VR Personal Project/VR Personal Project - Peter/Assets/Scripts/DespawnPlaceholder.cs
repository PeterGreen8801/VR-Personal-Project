using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnPlaceholder : MonoBehaviour
{
    public float spawnDelay = 5f;
    public void DespawnPlace()
    {
        IEnumerator Wait()
        {

            yield return new WaitForSeconds(spawnDelay);
            Destroy(GameObject.FindGameObjectWithTag("placeholder"));
        }
        StartCoroutine(Wait());
    }
}
