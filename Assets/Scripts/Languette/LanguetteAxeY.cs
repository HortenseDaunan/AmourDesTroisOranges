using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LanguetteAxeY : MonoBehaviour
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
            float imageLangY;
            Debug.Log(activated);
            if (transform.position.y >= posMin && transform.position.y <= posMax)
            {
                imageLangY = imageLang.transform.position.y - transform.position.y;
                Vector3 decalPosY = new Vector3(0f, Input.touches[0].deltaPosition.y, 0f);
                transform.position += decalPosY;
                imageLang.transform.position += decalPosY;

                //POSITION MIN
                if (transform.position.y < posMin)
                {
                    imageLang.transform.position = new Vector3(imageLang.transform.position.x, posMin + imageLangY, imageLang.transform.position.z);
                    transform.position = new Vector3(transform.position.x, posMin, transform.position.z);
                    if (goingdown == true)
                    {
                        activated = true;
                    }
                }

                //POSITION MAXI
                if (transform.position.y > posMax)
                {
                    imageLang.transform.position = new Vector3(imageLang.transform.position.x, posMax + imageLangY, imageLang.transform.position.z);
                    transform.position = new Vector3(transform.position.x, posMax, transform.position.z);
                    if (goingdown == false)
                    {
                        activated = true;
                    }
                }
            }
        }
        
    }

   
}
