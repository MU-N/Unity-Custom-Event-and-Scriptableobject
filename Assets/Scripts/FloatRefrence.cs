using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class FloatRefrence 
{
    public bool conidtant = true;
    public float ConsitanValue;
    public FloatVariableSO variable;

    public float Value
    {
        get { return conidtant ? ConsitanValue : variable.vlaue;  }
    }
}
