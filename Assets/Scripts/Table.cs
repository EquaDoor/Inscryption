using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    public List<Slot> frontLine = new List<Slot>();
    public List<Slot> enemyFrontLine = new List<Slot>();
    public List<Slot> nextLine = new List<Slot>();

    public List<CardData> cards = new List<CardData>();
    public List<Card> drawPile = new List<Card>();
    public List<Card> squirrelPile = new List<Card>();
    
    public Deck playerDeck;
    
    public void PlaceCard(Slot slot) {
        if(frontLine.Contains(slot)) slot.PlaceCard(playerDeck);
        // else if(nextLine.Contains(slot)) slot.PlaceCard(enemyDeck.hand);
        else Debug.LogError("Wrong slot");
    }
}
