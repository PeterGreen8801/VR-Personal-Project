using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CheckTopBun : MonoBehaviour
{
    public XRSocketInteractor socketInteractor;
    public GameObject attachedObject;

    [System.Obsolete]
    private void Start()
    {
        //socketInteractor.onSelectEntered.AddListener(OnSelectEntered);
        //socketInteractor.onSelectExited.AddListener(OnSelectExited);
    }
}
