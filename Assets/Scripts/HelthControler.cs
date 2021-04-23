using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelthControler : MonoBehaviour
{
    [SerializeField] Image HPValue;
    [SerializeField]  FloatVariableSO plyerHP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HPValue.fillAmount = plyerHP.vlaue ;
    }
}
