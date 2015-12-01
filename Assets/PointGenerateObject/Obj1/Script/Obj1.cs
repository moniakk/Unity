using UnityEngine;
using System.Collections;
using System;

public class Obj1 : BaseObject

{


    void Start()
    {

    }

    void Update()
    {
        transform.Translate(new Vector3(0, -.01f, 0));
    }
}
