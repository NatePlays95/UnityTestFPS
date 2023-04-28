using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableExample : MonoBehaviour, IInteractable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetActionName()
    {
        return "Print Random Number";
    }

    public void Interact()
    {
        Debug.Log(this.GetActionName());
        Debug.Log(Random.Range(0, 100));
    }
}
