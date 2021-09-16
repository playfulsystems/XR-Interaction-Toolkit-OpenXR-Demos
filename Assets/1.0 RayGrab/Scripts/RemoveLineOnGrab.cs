using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RemoveLineOnGrab : MonoBehaviour
{
    public XRRayInteractor rayInteractable;

    private void OnEnable()
    {
        //rayInteractable = GetComponent<XRRayInteractor>();
        //rayInteractable.selectEntered.AddListener(ObjectAttachedEvent);
        //rayInteractable.selectExited.AddListener(ObjectDetachedEvent);
    }

    private void OnDisable()
    {
        //rayInteractable.selectEntered.RemoveListener(ObjectAttachedEvent);
        //rayInteractable.selectExited.RemoveListener(ObjectDetachedEvent);
    }

    public void ObjectAttachedEvent(SelectEnterEventArgs arg0)
    {
        GetComponent<XRInteractorLineVisual>().enabled = false;
        //arg0.interactable.GetComponent<MeshRenderer>().material.color = Color.white;
    }

    public void ObjectDetachedEvent(SelectExitEventArgs arg0)
    {
        GetComponent<XRInteractorLineVisual>().enabled = true;
        //arg0.interactable.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void ObjectAttached()
    {
        GetComponent<XRInteractorLineVisual>().enabled = false;
    }

    public void ObjectDetached()
    {
        GetComponent<XRInteractorLineVisual>().enabled = true;
    }

}
