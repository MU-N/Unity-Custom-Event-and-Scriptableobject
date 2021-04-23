using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumpEnemy : MonoBehaviour
{
    [SerializeField] FloatVariableSO maxHP;
    [SerializeField] GameEvent helthController;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            helthController.Raise();
        }
    }

    public void changeHelth()
    {
        maxHP.vlaue -= 0.2f;
    }
}
