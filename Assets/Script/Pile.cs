using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pile : MonoBehaviour
{
    [Header("Variable Piles")]
    public int nbCartes;
    public GameObject mainJoueur;
    int prix;
    public bool passer;

    void Awake()
    { 
        if (passer == false) // Affichages des cartes de la pioche
        {
            GetComponent<Image>().sprite = GetComponent<Card>().sprCarte;
            prix = GetComponent<Card>().prix;
        }
    }

    void Update()
    {
        //Verifie si le joueur peux prendre une carte de la pile ou si il reste des cartes dans la pile
        if(nbCartes == 0 || prix > mainJoueur.GetComponent<Player>().argent || mainJoueur.GetComponent<Player>().piles ==false)
        {
            GetComponent<Button>().interactable = false; //desactivation du paquet 
        }
        else
        {
            GetComponent<Button>().interactable = true; //activation du paquet
        }
    }

    public void Onclick() // si le joueur veux acheter un carte de la pile
    {
        mainJoueur.GetComponent<Player>().mainJoueur.Add(GetComponent<Card>().Carte);
        mainJoueur.GetComponent<Player>().AfficherMain(GetComponent<Card>().Carte);
        nbCartes--;
        mainJoueur.GetComponent<Player>().argent -= prix;
        mainJoueur.GetComponent<Player>().piles = false;
        mainJoueur.GetComponent<Player>().joue = false;
        mainJoueur.GetComponent<Player>().tourDeEnnemi();

    }
    public void OnclickEnnemi() // si l'ordi veux acheter un carte de la pile
    {
        mainJoueur.GetComponent<Player>().ennemi.GetComponent<Player>().mainJoueur.Add(GetComponent<Card>().Carte);
        mainJoueur.GetComponent<Player>().ennemi.GetComponent<Player>().AfficherMain(GetComponent<Card>().Carte);
        nbCartes--;
        mainJoueur.GetComponent<Player>().ennemi.GetComponent<Player>().argent -= prix;
        mainJoueur.GetComponent<Player>().bEnnemi = false;
        mainJoueur.GetComponent<Player>().de.GetComponent<Dice>().activeDes();
        mainJoueur.GetComponent<Player>().joue = true;

    }
    public void Passer() //Si le joueur veut rien acheter
    {
        mainJoueur.GetComponent<Player>().piles = false;
        mainJoueur.GetComponent<Player>().joue = false;
        mainJoueur.GetComponent<Player>().tourDeEnnemi();
    }

}












/*for(int i = 0 ; i < nbCartes; i++)
        {
            cartes.Add(carte);
        }*/
/*for (int i = 0; i < 6; i++)
{
    cartes.Add(new Cards(1, "B","Immeuble 83", 1, 1));
    cartes.Add(new Cards(1, "B", "Epicerie solidaire", 1, 2));
    cartes.Add(new Cards(2, "V", "Mus�e du Papier", 2, 1));
    cartes.Add(new Cards(3, "R", "Bock n'Roll", 1, 2));
    cartes.Add(new Cards(4, "V", "Mus�e de la BD", 3, 2));
    cartes.Add(new Cards(5, "B", "Jardin Vert", 1, 2));
    cartes.Add(new Cards(5, "R", "RestoU", 2, 4));
    cartes.Add(new Cards(6, "B", "Cnam Enjmin", 5, 7));
    cartes.Add(new Cards(7, "B", "Cosmopolite", 2, 3));
    cartes.Add(new Cards(7, "B", "CGR", 1, 3));
    cartes.Add(new Cards(8, "V", "Patinoire", 2, 2));
    cartes.Add(new Cards(9, "R", "H�tel de ville", 1, 3));
    cartes.Add(new Cards(10, "V", "Gare SNCF", 3, 4));
    cartes.Add(new Cards(11, "B", "Bare Le Nil", 1, 2));
    cartes.Add(new Cards(11, "R", "E.Leclerc", 2, 4));
    cartes.Add(new Cards(12, "B", "Bord de la Charente", 4, 6));

}*/

//Debug
// Debug.Log(cartes.Count);
/*  foreach (Cards c in cartes)
  {
      Debug.Log(c);
  }*/