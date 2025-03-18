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

    public float yOffset = 0.5f;
    private Vector3 startPos;
    private Vector3 currPos;
    private float speed = 0.1f;
    
    //--------------------------------------------------------------------------------------------

    public void Init(Deck deck)
    {
        this.deck = deck;

        priceText.text = data.price.ToString();
        damageText.text = data.damage.ToString();
        healthText.text = data.health.ToString();

        startPos = transform.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,
            new Vector3(transform.position.x,currPos.y,transform.position.z), speed);
    }

    public void Use() => deck.SelectCard(this);

    private void OnMouseOver() => currPos = startPos + (Vector3.up*yOffset);
    void OnMouseExit() => currPos = startPos;
    void OnMouseDown() => Use();
}