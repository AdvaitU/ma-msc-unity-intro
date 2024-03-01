using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoReceiver : MonoBehaviour
{

    private string receivedString;
    private SerialPort serialPort;
    public CowSpawnCat _cow;

    void Start()
    {
        serialPort = new SerialPort("COM3", 9600);
        serialPort.Open();
    }

    void Update()
    {

        receivedString = serialPort.ReadLine();
        float f = float.Parse(receivedString);
        if (f <= 5.0f)
        {
            _cow.SpawnCat();
        }

    }

}
