using UnityEngine;
using System.Collections;

public class ReceivePosition : MonoBehaviour {
    
   	public OSC osc;
    public Material material;
    public CatSpawner spawner;


	// Use this for initialization
	void Start () {
       osc.SetAddressHandler("/CubeX", OnReceiveX);
       osc.SetAddressHandler("/CubeY", OnReceiveY);
       osc.SetAddressHandler("/CubeZ", OnReceiveZ);

       //material = GetComponent<Material>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnReceiveX(OscMessage message) {
        float x = message.GetFloat(0);
        Debug.Log(message.ToString());

        Vector3 position = transform.position;

        position.x = x;

        transform.position = position;
        material.color = new Color(x, 0, 0);

        if (x >= 0.9f) spawner.SpawnCat();

        Debug.Log("XReceived");
    }

    void OnReceiveY(OscMessage message) {
        float y = message.GetFloat(0);

        Vector3 position = transform.position;

        position.y = y;

        transform.position = position;
        Debug.Log("Y Received");
    }

    void OnReceiveZ(OscMessage message) {
        float z = message.GetFloat(0);

        Vector3 position = transform.position;

        position.z = z;

        transform.position = position;
        Debug.Log("Z Received");
    }



}
