using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetDistanceOfCollisions : MonoBehaviour
{
    public TextMeshPro distText;
    private void OnCollisionEnter(Collision collision)
    {
        float distFromMe = Vector3.Distance(Vector3.zero, collision.GetContact(0).point);
        distText.text = "Distance: " + distFromMe.ToString("#.00");
    }

}
