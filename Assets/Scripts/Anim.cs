using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Anim : MonoBehaviour
{
    [SerializeField] [Range(0f, 15f)] private float timeTurn = 0f;


    private void Start()
    {
        StartCoroutine(TurnPage());
    }

    IEnumerator TurnPage()
    {
        yield return new WaitForSeconds(timeTurn);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
