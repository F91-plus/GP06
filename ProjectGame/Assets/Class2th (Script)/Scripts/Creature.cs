using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    Stat creature = new();

    public Creature()
    {
        creature.name = "BearMonster";
        creature.level = 10;
        creature.headlth = 100;
        Debug.Log("Creature");
        Debug.Log(creature.name);
        Debug.Log(creature.level);
        Debug.Log(creature.headlth);
    }
}
