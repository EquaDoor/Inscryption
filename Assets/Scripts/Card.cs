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
    public Transform model;

    public Vector3 offset;
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

        startPos = model.position;
        currPos = startPos;
    }

    void Update()
    {
        model.position = Vector3.Lerp(model.position,
            new Vector3(model.position.x,currPos.y,model.position.z), speed);
    }

    public void Use() => deck.SelectCard(this);

    private void OnMouseOver() => currPos = startPos + offset;
    void OnMouseExit() => currPos = startPos;
    void OnMouseDown() => Use();
}