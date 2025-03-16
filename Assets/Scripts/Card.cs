using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public Deck deck;
    public CardData data;
    public void Use()
    {
        deck.SelectCard(this);
    }
}