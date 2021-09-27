using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketTagCheck : MonoBehaviour
{
    public GameObject objectToActivate;
    public string tagToCheck;
    XRSocketInteractor socketInteractor;

    void OnEnable()
    {
        socketInteractor = GetComponent<XRSocketInteractor>();

        socketInteractor.selectEntered.AddListener(OnSocketEnter);
        socketInteractor.selectExited.AddListener(OnSocketExit);
    }
    void OnDisable()
    {
        socketInteractor.selectEntered.RemoveListener(OnSocketEnter);
        socketInteractor.selectExited.RemoveListener(OnSocketExit);
    }
    void OnSocketEnter(SelectEnterEventArgs arg0)
    {
        Debug.Log(arg0.interactable.gameObject.tag);
        Debug.Log(tagToCheck);
        if (arg0.interactable.gameObject.tag == tagToCheck)
        {
            objectToActivate.SetActive(true);
        }
    }
    void OnSocketExit(SelectExitEventArgs arg0)
    {
        if (arg0.interactable.tag == tagToCheck)
        {
            objectToActivate.SetActive(false);
        }
    }

}
