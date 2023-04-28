using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteractUI : MonoBehaviour
{

    [SerializeField] private GameObject container;
    [SerializeField] private InteractorAgent playerInteractor;
    [SerializeField] private Text containerText;


    // Start is called before the first frame update
    void Start()
    {
        Hide(); 
    }

    // Update is called once per frame
    void Update()
    {
        IInteractable interactObj = playerInteractor.GetInteractableObject();
        if (interactObj != null)
        {
            Show(interactObj);
        } 
        else
        {
            Hide();
        }
    }

    private void Show(IInteractable interactObj)
    {
        containerText.text = "[E] " + interactObj.GetActionName();
        container.SetActive(true);
    }

    private void Hide()
    {
        container.SetActive(false);
    }
}
