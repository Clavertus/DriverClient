using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;
using TMPro;
using static System.Exception;

public class PortHandler : MonoBehaviour
{
    SerialPort sp;
    [SerializeField] Button connect_button;
    [SerializeField] TMP_InputField connect_port_name;

    public void ConnectToPort(){
        string portName = connect_port_name.text;
        sp = new SerialPort(portName, 115200);
        sp.Open();
    }

    void Update(){
        if(sp == null) return;
        if(sp.IsOpen)
        {
            Debug.Log(sp.ReadLine());
        }
        else 
        {
            Debug.Log("Port is closed");
        }
    }    
}
