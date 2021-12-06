using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlideY4 : MonoBehaviour
{
    private bool done;

    // Start is called before the first frame update
    void Start()
    {

        done = false;
    }

    IEnumerator action()
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("Page3");

    }

    private void Update()
    {
        if (done == false)
        {
            if (gameObject.GetComponent<LanguetteAxeX>().activated == true)
            {
                StartCoroutine(action());
                done = true;
            }
        }

    }
}

