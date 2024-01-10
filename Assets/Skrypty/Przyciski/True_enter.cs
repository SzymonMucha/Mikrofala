using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class True_enter : MonoBehaviour
{
    bool czy_czas=false;
    int temp;
    int czas;
    public Tekst tekst;
    Kurczak jedzenie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
      if(Input.GetMouseButtonDown(0))
      {
        if((jedzenie)&&(!jedzenie.done))
        {
            if(!czy_czas)
            {
                temp = tekst.wyswietlana;
                czy_czas=true;
                tekst.gonext();
            }
            else
            {
                czas = tekst.wyswietlana;
                czy_czas=false;
                jedzenie.getTime(temp,czas);
            }
        }
      }
    }
    public void set_object(GameObject other)
    {
        jedzenie=other.GetComponent<Kurczak>();;
    }
}
