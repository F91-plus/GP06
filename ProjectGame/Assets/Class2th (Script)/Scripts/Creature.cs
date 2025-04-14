using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    //Stat creature = new();
    private Stat stat2 = new Stat();

    public Creature()
    {
        //creature.name = "BearMonster";
        //creature.level = 10;
        //creature.health = 100;
        //Debug.Log("Creature");
        //Debug.Log(creature.Name);
        //Debug.Log(creature.Level);
        //Debug.Log(creature.Health);

        stat2.Level = 10;
        stat2.Health = 100;
        stat2.Name = "Bbbbb";
        Debug.Log("Level"+ stat2.Level);
        Debug.Log("Health" + stat2.Health);
        Debug.Log("Name" + stat2.Name);

        
    }
}

