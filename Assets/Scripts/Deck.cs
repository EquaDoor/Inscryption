using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> cards = new List<Card>();
    public Card hand;

    public void SelectCard(Card card) {
        cards.Remove(card);                                                                                                 
        hand = card;
    }
    public void DeselectCard(Card card) {
        cards.Add(hand);
        hand = null;
    }
}