using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Mana : MonoBehaviour
{
    /*public GameObject Canvas;*/
    public void hide()
    {
        gameObject.SetActive(false);
    }

    public void display()
    {
        gameObject.SetActive(true);
    }
}
