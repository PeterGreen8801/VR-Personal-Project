using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUncookedPatty : MonoBehaviour
{
    public GameObject uncooked;

    private Vector3 spawnPosition = new Vector3(-1.5f, 0.601999998f, -1.278f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Will spawn a new uncooked patty prefab at the spawn position
    public void spawn()
    {
        Instantiate(uncooked, spawnPosition, Quaternion.identity);
    }
}
