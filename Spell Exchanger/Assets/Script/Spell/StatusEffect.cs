using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StatusEffect : ScriptableObject
{
    /*public  enum Effect
    {
        POISON, BURN
    };*/
    float time = 0;
    float timeleft = 0;

    public void appliedEffect(GameObject character)
    {
        ScriptableObject a = Instantiate(this) as ScriptableObject;
    }
    public void endEffect(GameObject character)
    {
        Destroy(this);
    }
}
