using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Spell", menuName = "Spell/Spell")]
public class Spell : ScriptableObject
{
    [Header("spell catogry")]
    public string spellName;
    public string spellDescription;
    public string spellType;
    public string spellMode;
    public string spellId;
    public Image spellIcon;

    [Header("Casting Spell")]
    public float spellCost;
    public float spellCooldown;
    public float spellRange;
    public StatusEffect[] spellEffect = new StatusEffect[0];

    public void cast(GameObject obj) {
        if (spellMode == "Attack")
        {

        }
        else
        {

        }
    }
    public void setName(string name) { }
    public void setType(string type) { }
    public void setCost(float cost) { }
    public void setRange(float range) { }
    public string getName() { return spellName; }
    public string getType() { return spellType; }
    public string getMode() { return spellMode; }
    public float getCost() { return spellCost; }
    public float getRange() { return spellRange ; }
    public void otherCast(GameObject obj)
    {

    }
}
