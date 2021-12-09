using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{

    public bool On = true;
    public GameObject light;

    public void ToggleLight()
    {

        Debug.Log(On);

        On = !On;

        light.SetActive(On);


    }
}
