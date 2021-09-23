using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RotateInSocket : MonoBehaviour
{
    XRSocketInteractor socketInteractor;

    void Start()
    {
        socketInteractor = GetComponent<XRSocketInteractor>();
    }

    void Update()
    {
        if (socketInteractor.selectTarget != null)
        {
            float yRotSpeed = Time.deltaTime * 100f;
            transform.Rotate(0, yRotSpeed, 0);
        }
        else transform.rotation = Quaternion.identity;
    }
}
