using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeColorOnGrab : MonoBehaviour
{
    public XRGrabInteractable grabInteractable;

    private void OnEnable()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(ObjectAttachedEvent);
        grabInteractable.selectExited.AddListener(ObjectDetachedEvent);
    }

    private void OnDisable()
    {
        grabInteractable.selectEntered.RemoveListener(ObjectAttachedEvent);
        grabInteractable.selectExited.RemoveListener(ObjectDetachedEvent);
    }

    private void ObjectAttachedEvent(SelectEnterEventArgs arg0)
    {
        arg0.interactable.GetComponent<MeshRenderer>().material.color = Color.white;
    }

    private void ObjectDetachedEvent(SelectExitEventArgs arg0)
    {
        arg0.interactable.GetComponent<MeshRenderer>().material.color = Color.red;
    }

}
