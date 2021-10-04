using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{
    public AudioSource collisionSound;
    int collisionPoints;

    private void OnCollisionEnter(Collision collision)
    {
        collisionSound.pitch = Random.Range(0.75f, 1.25f);
        collisionSound.Play();
    }

    /*void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.contacts.Length > collisionPoints)
        {
            collisionSound.pitch = Random.Range(0.75f, 1.25f);
            collisionSound.Play();
        }

        collisionPoints = collisionInfo.contacts.Length;
    }*/
}
