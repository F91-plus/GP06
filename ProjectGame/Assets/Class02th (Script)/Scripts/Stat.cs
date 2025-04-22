using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat //new
{
    private int level;
    private int health;
    private string name;

    public int Level 
    { 
        get { return level; } 
        set 
        { 
            //if(value < 100)
            level = value; 
        } 
    }
    public int Health { get { return health; } set { health = value; } }
    public string Name { get { return name; } set { name = value; } }
}
