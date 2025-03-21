using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public Card card;


    public void PlaceCard(Card card, Deck deck) {
        this.card = card;
        card.transform.parent = transform;
    }

}
