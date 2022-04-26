using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class SocketChecking : MonoBehaviour
{

    XRSocketInteractor socket;

    public float disableDelay = 5f;

    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    public void socketCheck()
    {

        //IXRSelectInteractable objName = socket.GetOldestInteractableSelected();

        //Debug.Log(objName.transform.name + " in socket of " + transform.name);
    }

    public void diasable()
    {
        socket.enabled = false;
        Debug.Log("Socket turned off");
        IEnumerator Wait()
        {
            yield return new WaitForSeconds(disableDelay);
            socket.enabled = true;
            Debug.Log("Socket turned ON!");
        }
        StartCoroutine(Wait());
    }

    public void turnOff()
    {
        socket.enabled = false;
    }

    public void turnOn()
    {
        socket.enabled = true;
    }


}
