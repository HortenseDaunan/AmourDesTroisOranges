using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IlluManager : MonoBehaviour
{
    public List<Sprite> Illustrations;

    public GameObject ImageContainer;


    public void DisplayIllu(float pourcentage)
    {
        int indexImage = Mathf.FloorToInt(Illustrations.Count * pourcentage);
        if (indexImage < Illustrations.Count)
        {
            //affiche l'image 
            ImageContainer.GetComponent<Image>().sprite = Illustrations[indexImage];
        }

    }

}
