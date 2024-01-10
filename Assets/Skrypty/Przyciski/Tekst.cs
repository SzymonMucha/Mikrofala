using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tekst : MonoBehaviour
{
    private int[] liczba = new int [3];
    public int wyswietlana;
    private TextMeshProUGUI tekst;
    bool leci=false;
    public float tempo;
    Coroutine od;
    public Enter enter;
    public TextMeshProUGUI tekkst;
    public AudioSource beep;
    // Start is called before the first frame update
    void Start()
    {
        liczba[0]=0;
        liczba[1]=0;
        liczba[2]=0;
        tekst = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
            if(wyswietlana<10)
            {
                tekst.text="    "+wyswietlana.ToString();
            }
            else if(wyswietlana<100)
            {
                tekst.text="  "+wyswietlana.ToString();
            }
            else
            {
                tekst.text=wyswietlana.ToString();
            }
    }
    public void wystartuj()
    {
        od=StartCoroutine(Odliczanie());
        leci=true;
    }
    public void zatrzymaj1()
    {
        StopCoroutine(od);
        leci=false;
    }
    public void Uliczbienie(int number)
    {
        if(!leci)
        {
            liczba[0]=liczba[1];
            liczba[1]=liczba[2];
            liczba[2]=number;
            wyswietlana=liczba[0]*100+liczba[1]*10+liczba[2];
            beep.Play();
        }
    }
    IEnumerator Odliczanie()
    {
        yield return new WaitForSeconds(tempo/1000);
        wyswietlana--;
        if(wyswietlana>0)
        {
            od=StartCoroutine(Odliczanie());
        }
        else
        {
            leci=false;
            enter.end();
        }
    }
    public void gonext()
    {
        wyswietlana=0;
        tekkst.text="mS";
        liczba[0]=0;
        liczba[1]=0;
        liczba[2]=0;
    }
    public void goback()
    {
        wyswietlana=0;
        tekkst.text="°kC";
        liczba[0]=0;
        liczba[1]=0;
        liczba[2]=0;
        zatrzymaj1();
    }
}