using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeColorInSocket : MonoBehaviour
{
    public XRSocketInteractor socketInteractor;

    private void OnEnable()
    {
        socketInteractor = GetComponent<XRSocketInteractor>();
        socketInteractor.selectEntered.AddListener(ObjectAttachedEvent);
        socketInteractor.selectExited.AddListener(ObjectDetachedEvent);
    }

    private void OnDisable()
    {
        socketInteractor.selectEntered.RemoveListener(ObjectAttachedEvent);
        socketInteractor.selectExited.RemoveListener(ObjectDetachedEvent);
    }

    public void ObjectAttachedEvent(SelectEnterEventArgs arg0)
    {
        arg0.interactable.GetComponent<MeshRenderer>().material.color = Color.white;
    }

    public void ObjectDetachedEvent(SelectExitEventArgs arg0)
    {
        arg0.interactable.GetComponent<MeshRenderer>().material.color = Color.red;
    }

}
