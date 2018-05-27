using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVLGeneration : MonoBehaviour {
    //on se réfère a la plateforme utilisée
    public GameObject platformPrefab;
    //on stocke le nombre de plateformes générées dès le lancement du jeu dans la variable suivante
    public int NombrePlatformes = 200;
    //on utilise des variables afin de définir la taille du niveau
    public float largeur = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;

    //Fonction de départ
    void Start()
    {

        Vector3 spawnPosition = new Vector3();
        //on réalise une boucle qui se termine lorsque la boucle a été effectué le même nombre de fois que la valeur attribué a la variable "NombrePlatformes"
        for (int i = 0; i < NombrePlatformes; i++)
        {
            //chaque plateforme est séparée sur l'axe des ordonés, de manière aléatoire comprise entre les valeurs attribués aux variables "minY" et "maxY"
            spawnPosition.y += Random.Range(minY, maxY);
            //chaque plateforme est séparée sur l'axe des abscices, de manière aléatoire comprise entre la valeur négative et positive attribué a la variable "largeur"
            spawnPosition.x = Random.Range(-largeur, largeur);
            //on clone la plateforme référente sans lui donner de rotation
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
