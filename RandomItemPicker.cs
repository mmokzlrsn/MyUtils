using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  RandomItemPicker  MonoBehaviour
{
    //Start is called before the first frame update[]
     
    void Start()
    {
        
    }

     Update is called once per frame
    void Update()
    {
         
    }

    public Colors GiveRandomColor()
    {
        var rnd = new System.Random();
        Colors color;
        do
        {
            color = (Colors)rnd.Next(Enum.GetNames(typeof(Colors)).Length);
        } while (color == Colors.WHITE);
        return color;
    }


}
