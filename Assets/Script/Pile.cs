using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pile : MonoBehaviour
{

    public int nbCartes;

    public Pile()
    {
        nbCartes = 6;       
    }

    void Awake()
    {
        GetComponent<Image>().sprite = GetComponent<Card>().sprCarte;
    }

    public override string ToString()
    {
        string toString = string.Format("");
        return toString;
    }

    void Update()
    {
        if(nbCartes == 0)
        {
            GetComponent<Button>().interactable = false;
        }
    }

    void Onclick()
    {

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