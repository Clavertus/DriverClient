using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using TMPro;

public class PortScanner : MonoBehaviour
{

    public TMP_Dropdown connect_dropdown;
    public List<TMP_Dropdown.OptionData> optionList;


    void Awake(){       
        optionList = new List<TMP_Dropdown.OptionData>();
        string[] ports = SerialPort.GetPortNames();
        Debug.Log("The following serial ports were found:");
        AddOptionsToList(ports);
    }

    public void AddOptionsToList(string[] portNames)
    {
        connect_dropdown.ClearOptions();
        optionList = new List<TMP_Dropdown.OptionData>();
        foreach(string port in portNames)
        {
            TMP_Dropdown.OptionData newOption = new TMP_Dropdown.OptionData();
            newOption.text = port;
            optionList.Add(newOption);
            connect_dropdown.options.Add(newOption);         
        }
    }

}
