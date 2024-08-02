using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorReset : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
      anim = GetComponent<Animator>();  
    }

    void DoorResetToBase()
    {
        anim.SetInteger("AnimState", 0);
    }
}
