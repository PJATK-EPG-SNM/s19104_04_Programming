using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    //nie mam dokladnie jak na zajeciach gdyz koniunkcje i zmienne znalem wiec wypisywalem wybiorczo
    //i na koniec jakos na szybko chcialem wypisac mniej wiecej pamietajac co dokladnie bylo
    
    
    private bool amulet = true;
    private int health = 2;
    private int time = 1;

    void Start()
    {
        int a = 10;
        int b = 20;

        float zm = 2.5f;

        Debug.Log(a);
        Debug.Log(a/zm);
        Debug.Log(Mathf.Sqrt(a));

        Metoda(a, b);
        Amulet();

        /*koniunkcja
       && - and
       || - or
       != - rozne
       == - takie same
         */

        
    }


    void Update()
    {
        
    }

    public void Metoda(int a, int b)
    {
        if (a != b)
        {
            Debug.Log("Tak, jest różna!");
        }
        else
        {
            Debug.Log("Tak, jest taka sama!");
        }
    }

    public void Amulet()
    {
        if(health<1 || time < 1)
        {
            if (amulet)
            {
                Debug.Log("Zyjesz");
            }
            else
            {
                Debug.Log("Umierasz");
            }
        }



    }
}
