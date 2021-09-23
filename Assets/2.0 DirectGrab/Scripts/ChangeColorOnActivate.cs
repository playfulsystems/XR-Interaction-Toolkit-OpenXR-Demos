using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeColorOnActivate : MonoBehaviour
{
    public XRGrabInteractable grabInteractable;

    private void OnEnable()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(ObjectActivateEvent);
        grabInteractable.deactivated.AddListener(ObjectDeactivateEvent);
    }

    private void OnDisable()
    {
        grabInteractable.activated.RemoveListener(ObjectActivateEvent);
        grabInteractable.deactivated.RemoveListener(ObjectDeactivateEvent);
    }

    private void ObjectActivateEvent(ActivateEventArgs arg0)
    {
        arg0.interactable.GetComponent<MeshRenderer>().material.color = Color.white;
    }

    private void ObjectDeactivateEvent(DeactivateEventArgs arg0)
    {
        arg0.interactable.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
