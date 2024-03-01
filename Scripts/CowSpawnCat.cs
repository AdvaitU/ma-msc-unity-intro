using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowSpawnCat : MonoBehaviour
{

    // Members
    public GameObject cat;
    public Transform spawnPoint;
    public GameObject player;
    
    [Range(5f, 25)]
    public float proximityMargin = 10.0f;
    [Range(5, 25)]
    public float jumpMargin = 5.0f;
    [Range(0, 5f)]
    public float jumpHeight = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnCat();

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
        
        if ((Input.GetKeyDown(KeyCode.E)) && (distance <= proximityMargin))
        {
            SpawnCat();
        }

        //Debug.Log(distance);

    }

    public void SpawnCat()
    {
        Instantiate(cat, spawnPoint);
    }

}
