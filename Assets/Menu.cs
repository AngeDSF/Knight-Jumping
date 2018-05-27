using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//on utilise une classe qui regroupe des fonctions propres a la gestion des scenes
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    //fonction de départ
    public void LancementDuJeu()
    {
        //lance la scene nommée "jeu"
        SceneManager.LoadScene("jeu");
    }
       
    public void QuitterJeu ()
    {
        //ferme l'application
        Application.Quit();
    }
}