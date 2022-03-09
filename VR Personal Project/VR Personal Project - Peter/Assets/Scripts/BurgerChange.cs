using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerChange : MonoBehaviour
{

    public GameObject uncooked;
    public GameObject cooked;
    private Vector3 posA = Vector3.zero;
    private Vector3 posB = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Swap()
    {
        posA = uncooked.gameObject.transform.position;
        posB = cooked.gameObject.transform.position;
        Destroy(uncooked);
        cooked.gameObject.transform.position = posA;
    }

    //will get the position of the uncooked burger, destroy it, and then spawn a cooked one in its previous position.
    public void Replace()
    {
        posA = uncooked.gameObject.transform.position;
        posB = cooked.gameObject.transform.position;
        Destroy(uncooked);


    }
}
