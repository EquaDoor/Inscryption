using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> cards = new List<Card>();
    public Card hand;

    public float cardSpacing = 1f;
    public float cardGap = 0.01f;
    
    //--------------------------------------------------------------------------------------------

    void Start()
    {
        if(transform.childCount > 0) cards.Clear();
        foreach(Transform c in transform) {
            Card tmp = c?.GetComponent<Card>();
            cards.Add(tmp);
            tmp.Init(this);
        }
    }

    //--------------------------------------------------------------------------------------------

    public void SelectCard(Card card) {
        cards.Remove(card);
        hand = card;
    }
    public void DeselectCard(Card card) {
        cards.Add(hand);
        hand = null;
    }
}