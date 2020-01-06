using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SimpleFunction();
        int dmg = DamageCalc(15, 3);

    }

    void SimpleFunction()
    {
        Debug.Log("T-pose");
    }

    public int DamageCalc(int damage, int armor)
    {
        Debug.Log("Great job you got his head!" + (damage - armor) + "Damage");
        return damage - armor;
    }
}
