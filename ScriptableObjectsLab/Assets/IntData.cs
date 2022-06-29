using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(filename = "New Card", menuName = "Cards/Minion")]
public class Card : ScriptableObject
{
    public new string name;
    public string description;
    
    public Sprite artwork;

    public int manaCost;
    public int attack;
    public int health;
    
} 