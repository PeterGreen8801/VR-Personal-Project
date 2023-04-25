using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CheeseSocketCheck : MonoBehaviour
{
    public XRSocketInteractor socketInteractor;
    public GameObject attachedObject;

    [System.Obsolete]
    private void Start()
    {
        socketInteractor.onSelectEntered.AddListener(OnSelectEntered);
        socketInteractor.onSelectExited.AddListener(OnSelectExited);
    }

    private void OnSelectEntered(XRBaseInteractable interactable)
    {
        if (socketInteractor.selectTarget != null)
        {
            if (attachedObject.tag == "Cheese")
            {
                Debug.Log("Cheese added on");
                this.gameObject.tag = "Complete Cheese";
                Debug.Log("Tag changed to " + this.gameObject.tag);
            }
        }
    }

    private void OnSelectExited(XRBaseInteractable interactable)
    {
        this.gameObject.tag = "Cheese";
        Debug.Log("Tag changed to " + this.gameObject.tag);
    }
}
