using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HornTrigger : MonoBehaviour
{
    public AudioSource _horn;

    private void OnTriggerEnter(Collider other)
    {
        _horn.Play();
    }

}
