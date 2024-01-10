using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public Kurczak jedzenie;
    public SpriteRenderer sr;
    public Sprite close;
    public Sprite open;
    public MeshRenderer mr;
    public Tekst tekst;
    public Animator anime;
    public AudioSource adieu;
    public AudioSource adieu2;
    public AudioSource adieu3;
    public AudioSource ding;
    // Start is called before the first frame update
    void Start()
    {
        anime.SetBool("Geygerzy", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseOver()
    {
      if(Input.GetMouseButtonDown(0))
      {
        if(jedzenie)
        {
            end();
        }
      }
    }
    public void set_object(GameObject other)
    {
        jedzenie=other.GetComponent<Kurczak>();;
    }
    public void end()
    {
        if(!jedzenie.done)
        {
            if(sr.sprite==open)
            {
                jedzenie.start_flip();
                sr.sprite=close;
                mr.enabled=true;
                tekst.wystartuj();
                anime.SetBool("Geygerzy", true);
                adieu.Play();
                adieu2.Play();
                adieu3.Play();
            }
            else if(sr.sprite==close)
            {
                jedzenie.stop();
                sr.sprite=open;
                mr.enabled=false;
                tekst.zatrzymaj1();
                anime.SetBool("Geygerzy", false);
                adieu.Stop();
                adieu2.Stop();
                ding.Play();
                tekst.goback();
            }
        }
    }
}
