using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    public Deck deck; // check if players
    public Table table;
    public CardData data;
    public TMP_Text priceText;
    public TMP_Text damageText;
    public TMP_Text healthText;
    public Transform model;

    public Vector3 offset;
    private Vector3 startPos;
    private Vector3 currPos;
    private float speed = 0.1f;

    private CardState currentState;
    private enum CardState
    {
        Hand,
        Table,
        Draw
    }
    
    //--------------------------------------------------------------------------------------------

    public void Init(Deck deck = null, Table table = null)
    {
        if(deck != null) {
            this.deck = deck;
            currentState = CardState.Hand;
        }
        if(table != null){
            this.table = table;
            currentState = CardState.Table;
        }

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

    public void Use() {
        if(currentState == CardState.Hand) deck.SelectCard(this);
        else if(currentState == CardState.Draw) table.GetCard(this);
    }

    private void OnMouseOver() => currPos = startPos + offset;
    void OnMouseExit() => currPos = startPos;
    void OnMouseDown() => Use();
}