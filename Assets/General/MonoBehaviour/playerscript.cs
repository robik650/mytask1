using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Hero", menuName = "Hero Data", order = 51)]
public class playerscript : ScriptableObject
{
    [SerializeField]
    private string heroname;
    [SerializeField]
    private string description;
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private int HP;
    [SerializeField]
    private int attackDamage;

     public string Heroname
    {
        get
        {
            return heroname;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
    }

    public Sprite Icon
    {
        get
        {
            return icon;
        }
    }

    public int Hp
    {
        get
        {
            return HP;
        }
    }

    public int AttackDamage
    {
        get
        {
            return attackDamage;
        }
    }
}
