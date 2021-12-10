using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideY1 : MonoBehaviour
{
    private bool done;
    public GameObject slider2;

    void Start()
    {
        done = false;
    }
    
    IEnumerator action()
    {
        slider2.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
    }

    private void Update()
    {
        if (done == false)
        {
            if (gameObject.GetComponent<LanguetteAxeY>().activated == true)
            {
                StartCoroutine(action());
                done = true;
            }
        }
    }
}
