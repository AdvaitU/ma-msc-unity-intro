using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThudScript : MonoBehaviour
{

    public AudioSource thud;
    private bool playOnce = true;

    private void Update()
    {
        if (gameObject.transform.position.y <= 2.0f && playOnce)
        {
            thud.Play();
            playOnce = false;
        }

    }
}
