using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUncookedPatty : MonoBehaviour
{
    public GameObject originalObject;
    public Transform spawnPosition;



    public void SpawnPatty()
    {
        Instantiate(originalObject, spawnPosition.position, spawnPosition.rotation);
    }
}
