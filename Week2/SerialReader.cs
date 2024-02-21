using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class SerialReader : MonoBehaviour
{
    private SerialPort serialPort;
    private string recdString = "1.0";
    public CatSpawner _spawner;

    // Start is called before the first frame update
    void Start()
    {

        serialPort = new SerialPort("COM3", 9600);
        serialPort.Open();
        
    }

    // Update is called once per frame
    void Update()
    {
        recdString = serialPort.ReadLine();   // Read the line from the serial port
        float f = float.Parse(recdString);

        if (f <= _spawner.proximityMargin)
        {
            _spawner.SpawnCat();
        }

    }
}
