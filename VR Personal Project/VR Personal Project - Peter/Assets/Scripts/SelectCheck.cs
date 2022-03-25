using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SelectCheck : MonoBehaviour
{
    public GameObject objectToCheck;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        XRSocketInteractor socket = gameObject.GetComponent<XRSocketInteractor>();
        // socket.selectEntered.AddListener(SelectChecker);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SelectChecker(XRBaseInteractable obj)
    {
        Destroy(objectToCheck);
    }

    public void delete()
    {
        Destroy(objectToCheck);
    }

}
