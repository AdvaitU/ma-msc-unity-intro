using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowingScript : MonoBehaviour
{

    public GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = _player.transform.position;
    }
}
