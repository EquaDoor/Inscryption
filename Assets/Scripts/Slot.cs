using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public Card card;
    // public Transform card

    public void PlaceCard(Deck deck) {
        deck.hand.transform.parent = this.transform;
        deck.layout.RemoveObj(deck.hand.transform);
        deck.hand.transform.position = this.transform.position;
        deck.hand.transform.rotation = Quaternion.identity;
        deck.hand.transform.localScale = this.transform.localScale;
        deck.hand = null;
    }
}
