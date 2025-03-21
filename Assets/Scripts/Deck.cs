using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public ObjectLayout layout;

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

    public void GetCard(Card card) {
        card.transform.parent = this.transform;
        layout.AddObj(card.transform);
        card.transform.position = this.transform.position;
        card.transform.rotation = Quaternion.identity;
        // hand.transform.localScale = this.transform.localScale;
        cards.Add(card);
    }
}