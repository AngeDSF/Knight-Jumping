using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//pour que ce script soit fonctionel il faut qu'un objet de type "rigidbody2D" soit présent
[RequireComponent(typeof(Rigidbody2D))]
public class KnightMouvement : MonoBehaviour {

    public float vitesse = 10f;

    Rigidbody2D rb;
    //quand aucune touche n'est pressée le personnage est immobile
    float mouvement = 0f;

    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //le mouvement est définie par la touche horizontale pressée et ce mouvement peut etre accentué en modifiant la variable "vitesse"     
        mouvement = Input.GetAxis("Horizontal") * vitesse;
    }

    void FixedUpdate()
    {
        //on définie un vecteur
        Vector2 velocity = rb.velocity;
        //on modifie ça vitesse en "x" par la valeur attribué a la variable "mouvement"
        velocity.x = mouvement;
        //et enfin on attribue les propriétés de ce vecteur au vecteur de l'objet en question (donc ici au personnage)
        rb.velocity = velocity;
    }

}

