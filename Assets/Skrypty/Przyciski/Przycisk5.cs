using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Przycisk5 : MonoBehaviour
{
    public Tekst skrypt;
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
        skrypt.Uliczbienie(5);
      }
    }
}
