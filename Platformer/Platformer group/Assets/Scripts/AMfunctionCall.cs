using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMfunctionCall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int dmg = GetComponent<AMFunctions>().DamageCalc(10, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
