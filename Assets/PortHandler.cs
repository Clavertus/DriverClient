using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;
using TMPro;
using static System.Exception;
using System.Linq;

public class PortHandler : MonoBehaviour
{
    SerialPort sp;
    [SerializeField] Button connect_button;
    [SerializeField] TMP_Dropdown connect_dropdown;
    PortScanner ps;


    public void ConnectToPort(){
        ps = GetComponent<PortScanner>();  
      //  Debug.LogError(ps.optionList[0].text);
        string portName = ps.optionList[0].text;
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
