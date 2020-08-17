using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Asteroid", menuName = "Asteroid Data", order = 51)]
public class enemyscript : ScriptableObject
{
   [SerializeField]
    private string asteroidname;
    [SerializeField]
    private string description;
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private int HP;
   

     public string Asteroidname
    {
        get
        {
            return asteroidname;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
    }

    public int Hp
    {
        get
        {
            return HP;
        }
    }
}
