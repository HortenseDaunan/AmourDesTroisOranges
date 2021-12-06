using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IlluManager : MonoBehaviour
{
    public List<Sprite> Illustrations;

    int IndexIllu;
    public GameObject ImageContainer;

    void Start()
    {
        IndexIllu = 0;
    }

    public void DisplayIllu()
    {
        //Sécurité : permet de ne pas prendre une image en dehors de la liste
        if (IndexIllu < Illustrations.Count){
            //affiche l'image 
            ImageContainer.GetComponent<Image>().sprite = Illustrations[IndexIllu];
            //rajoute 1 à index illus
            IndexIllu = IndexIllu + 1;
        }
    }

}
