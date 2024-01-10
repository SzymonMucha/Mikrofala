using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Kurczak : MonoBehaviour
{
   private Transform transform;
   public Enter enter;
   public True_enter tenter;
   private Coroutine flop;
   public Tekst tekst;
   public int temper;
   public int time;
   private SpriteRenderer sr;
   public Sprite raw;
   public Sprite good;
   public Sprite burnt;
   public Sprite dead;
   public int sumtempgood;
   public int sumtempburnt;
   public int sumtempdead;
   public AudioSource Maska1;
   public AudioSource Maska2;
   public AudioSource Mlask;
   public AudioSource trzask;
   public AudioSource syreny;
   public AudioSource geyeye;
   public VideoPlayer hey;
   public Animator anim;
   public Animator bum;
   public Animator gey;
   public bool done;
   public bool wodor;
    // Start is called before the first frame update
    void Start()
    {
        transform=GetComponent<Transform>();
        sr=GetComponent<SpriteRenderer>();
        done=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseOver()
    {
      if(Input.GetMouseButtonDown(0))
      {
         if(!done)
         {
            transform.position=new Vector2(-2.43f,-0.38f);
            enter.set_object(gameObject);
            tenter.set_object(gameObject);
         }
         else
         {
            if(!wodor)
            {
               StartCoroutine(Maska());
            }
            else
            {
               bum.SetBool("BUM", true);
               StartCoroutine(rum());
               syreny.Stop();
               geyeye.Stop();
            }
         }
      }
    }
    public void start_flip()
    {
      flop=StartCoroutine(flip());
    }
    IEnumerator flip()
    {
      yield return new WaitForSeconds(1f);
      transform.localScale=new Vector3(-transform.localScale.x,transform.localScale.y,1f);
      flop=StartCoroutine(flip());
    }
    public void stop()
    {
      StopCoroutine(flop);
      time-=tekst.wyswietlana;
      if(!wodor)
      {
         if(time*temper>=sumtempdead)
         {
            sr.sprite=dead;
         }
         else if(time*temper>=sumtempburnt)
         {
            sr.sprite=burnt;
         }
         else if(time*temper>=sumtempgood)
         {
            sr.sprite=good;
         }
      }
      else
      {
         syreny.Play();
         StartCoroutine(gegee());
      }
      done=true;
    }
    public void getTime(int temp, int czas)
    {
      temper=temp;
      time=czas;
    }
    IEnumerator Maska()
    {
         Maska1.Play();
         anim.SetBool("On", false);
         anim.SetBool("Zdejmowanie", true);
         yield return new WaitForSeconds(2f);
         anim.SetBool("Zdejmowanie", false);
         Mlask.Play();
         sr.enabled=false;
         yield return new WaitForSeconds(3f);
         Maska1.Play();
         anim.SetBool("Zakładanie", true);
         yield return new WaitForSeconds(2f);
         trzask.Play();
         anim.SetBool("Zakładanie", false);
         anim.SetBool("On", true);
         yield return new WaitForSeconds(0.001f);
         transform.position=new Vector2(9.23f,-2.77f);
         sr.sprite=raw;
         done=false;
         sr.enabled=true;
    }
    IEnumerator rum()
    {
      yield return new WaitForSeconds(1f);
      bum.SetBool("BUM", false);
      gey.SetBool("Geygerzy", false);
      hey.Play();
    }
    IEnumerator gegee()
    {
      yield return new WaitForSeconds(0.01f);
      geyeye.Play();
      gey.SetBool("Geygerzy", true);
    }
}
