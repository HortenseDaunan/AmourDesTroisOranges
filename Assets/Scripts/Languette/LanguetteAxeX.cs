using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LanguetteAxeX : MonoBehaviour
{
    [SerializeField] private GameObject imageLang = null;
    public bool activated = false;
    public bool goingdown = false;
    public float posMin = 0f;
    public float posMax = 1f;

    public void DragLang(BaseEventData data)
    {
        if (activated == false)
        {
            float imageLangX;
            Debug.Log(activated);
            if (transform.position.x >= posMin && transform.position.x <= posMax)
            {
                imageLangX = imageLang.transform.position.x - transform.position.x;
                Vector3 decalPosX = new Vector3(Input.touches[0].deltaPosition.x, 0f, 0f);
                transform.position += decalPosX;
                imageLang.transform.position += decalPosX;

                //POSITION MIN
                if (transform.position.x < posMin)
                {
                    imageLang.transform.position = new Vector3(posMin + imageLangX, imageLang.transform.position.y, imageLang.transform.position.z);
                    transform.position = new Vector3(posMin, transform.position.y, transform.position.z);
                    if (goingdown == true)
                    {
                        activated = true;
                    }
                }

                //POSITION MAXI
                if (transform.position.x > posMax)
                {
                    imageLang.transform.position = new Vector3(posMax + imageLangX, imageLang.transform.position.y, imageLang.transform.position.z);
                    transform.position = new Vector3(posMax, transform.position.y, transform.position.z);
                    if (goingdown == false)
                    {
                        activated = true;
                    }
                }
            }

            
        }

    }

}