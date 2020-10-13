using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playanimtl : MonoBehaviour
{
    public string animation_name;
    private Animator anim;
    //public GameObject Pr;
    // Start is called before the first frame update
    void Start()
    {
         anim = gameObject.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown() 
    {
     anim.Play(animation_name);
    }
}
