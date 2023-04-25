using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LettuceSocketCheck : MonoBehaviour
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
            if (attachedObject.tag == "Lettuce")
            {
                Debug.Log("Lettuce added on");
                this.gameObject.tag = "Complete Lettuce";
                Debug.Log("Tag changed to " + this.gameObject.tag);
            }
        }
    }

    private void OnSelectExited(XRBaseInteractable interactable)
    {
        this.gameObject.tag = "Lettuce";
        Debug.Log("Tag changed to " + this.gameObject.tag);
    }
}
