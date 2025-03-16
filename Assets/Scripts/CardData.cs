using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "c_", menuName = "Scriptables/Cards/New Card")]
public class CardData : ScriptableObject
{
    public int price;
    public int health;
    public int damage;
}
