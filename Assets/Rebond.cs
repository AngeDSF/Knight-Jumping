using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebond : MonoBehaviour {
    //cela défini la quantité de force appliqué, plus la valeur est élevée, plus le personnage saute haut
    public float jumpforce = 10f;
    //la fonction s'effectue lorsque deux objets rentrent en collision
    void OnCollisionEnter2D(Collision2D collision)
    {
        //si le personnage rentre en collision avec la plateforme depuis une position en "y" plus élevée
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            //si au moins l'un des deux objets qui rentrent en collision possède le composant "rigidbody"
            if (rb != null)
            {
                //on définie un vecteur              
                Vector2 velocity = rb.velocity;
                //on modifie ça vitesse en "y" par la valeur attribué a la variable "jumpfroce"
                velocity.y = jumpforce;
                //et enfin on attribue les propriétés de ce vecteur au vecteur de l'objet en question (donc ici au personnage)
                rb.velocity = velocity;
            }

        }

    }

}