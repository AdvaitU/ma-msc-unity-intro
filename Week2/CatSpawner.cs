using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{

    public GameObject _cat;         // Reference to the cat prefab
    public Transform spawnPoint;      // Reference to the Spawn Point object's transform
    public GameObject _player;        // Reference to the player object

    [SerializeField] public float proximityMargin = 5.0f;

    

    void Start()
    {
        //SpawnCat();
    }


    void Update()
    {

        /*float distance = Vector3.Distance(gameObject.transform.position, _player.transform.position);
        Debug.Log(distance);

        if (Input.GetKeyDown(KeyCode.E) && (distance <= proximityMargin))     // If 'E' is pressed
        {
            SpawnCat();
        }*/



    }

    public void SpawnCat()          //camelCase
    {
        Instantiate(_cat, spawnPoint);   // Instantiating the cat GameObject at transform spawPoint
    }



}
