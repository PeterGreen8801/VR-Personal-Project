using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TurnOffGrab : MonoBehaviour
{
    public bool canGrab = true;

    XRGrabInteractable pattygrab;

    public float disableDelay = 5f;

    void Start()
    {
        pattygrab = GetComponent<XRGrabInteractable>();
    }

    [SerializeField] GameObject uncooked;

    public void turnOffGrab()
    {
        pattygrab.enabled = false;
        IEnumerator Wait()
        {
            yield return new WaitForSeconds(disableDelay);
            pattygrab.enabled = true;
            Debug.Log("Socket turned ON!");
        }
        StartCoroutine(Wait());
    }

}
