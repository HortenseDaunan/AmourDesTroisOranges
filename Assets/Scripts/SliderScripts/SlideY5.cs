using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SlideY5 : MonoBehaviour
{
    private bool done;
    public GameObject slider2;
    // Start is called before the first frame update
    void Start()
    {

        done = false;
    }

    IEnumerator action()
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("Page4");

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
