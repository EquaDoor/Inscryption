using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    public Deck deck;
    public CardData data;
    public TMP_Text priceText;
    public TMP_Text damageText;
    public TMP_Text healthText;
    
    //--------------------------------------------------------------------------------------------

    public void Init(Deck deck)
    {
        this.deck = deck;

        priceText.text = data.price.ToString();
        damageText.text = data.damage.ToString();
        healthText.text = data.health.ToString();
    }

    public void Use()
    {
        deck.SelectCard(this);
    }
}