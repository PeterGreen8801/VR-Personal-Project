using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CompleteBurger : MonoBehaviour
{
    public XRSocketInteractor socketInteractor;
    public GameObject attachedObject;

    //public GameObject targetObject;

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
            /*
            attachedObject = socketInteractor.selectTarget.gameObject;
            if (attachedObject == targetObject)
            {
                // Do something with the attached object
            } */
            if (attachedObject.tag == "Top Bun")
            {
                Debug.Log("Top Bun added on");
                this.gameObject.tag = "Complete Burger";
                Debug.Log("Tag changed to " + this.gameObject.tag);
            }
        }
    }

    private void OnSelectExited(XRBaseInteractable interactable)
    {
        //attachedObject = null;
        this.gameObject.tag = "Patty Cooked";
        Debug.Log("Tag changed to " + this.gameObject.tag);
    }
}
