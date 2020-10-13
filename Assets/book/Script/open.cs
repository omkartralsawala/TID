using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open : MonoBehaviour
{
    public GameObject Books;
    public string animation_name;
    public string animation_name2;
    private Animator anim;
    private Animator anim2;
    //public GameObject Pr;
    // Start is called before the first frame update
    void Start()
    {
         anim = Books.transform.GetComponent<Animator>();
         anim2 = gameObject.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() 
    {
     anim.Play(animation_name);
     anim2.Play(animation_name2);
    }
}
