using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class SpawnFromPool : MonoBehaviour
{
    public Transform spawnPosition = null;


    public void PoolSpawn()
    {
        //spawnPosition.
        var uncooked = BasicPool.Instance.GetFromPool();

        uncooked.transform.position = spawnPosition.position;
    }




    public void socketCheck()
    {

        //IXRSelectInteractable objName = socket.GetOldestInteractableSelected();

        //Debug.Log(objName.transform.name + " in socket of " + transform.name);
    }
}
