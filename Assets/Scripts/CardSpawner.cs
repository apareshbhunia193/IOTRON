using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardSpawner : MonoBehaviour
{

    [SerializeField] GameObject cardPrefab;
    TMP_Text cardInfoText;

    char[] cardType = {'c', 'h', 's', 'd'};
    string[] cardInfo = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
    void Start()
    {
        InstantiateTheCards();
    }

    void InstantiateTheCards(){
        for (int i = 0, a = 0; i <4 ; i++, a++){
            for (int j = 0, b = 0; j<13 ; j++, b++){
                GameObject card = Instantiate(cardPrefab, transform);
                cardInfoText = card.GetComponentInChildren<TMP_Text>();
                cardInfoText.text = cardInfo[b] + " " + cardType[a];
            }
        }
    }
}
