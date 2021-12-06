using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlideY3 : MonoBehaviour
{
    private bool done;

    void Start()
    {
        done = false;
    }

    IEnumerator action()
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("Page2");

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
