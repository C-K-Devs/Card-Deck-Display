using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardManager : MonoBehaviour
{
    public GameObject cardPrefab; // Assign the card prefab in the Inspector
    public Transform cardGridPanel; // Assign the CardGridPanel in the Inspector

    private List<string> suits = new List<string> { "c", "h", "s", "d" };
    private List<string> values = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

    void Start()
    {
        GenerateCards();
    }

    void GenerateCards()
    {
        foreach (string suit in suits)
        {
            foreach (string value in values)
            {
                GameObject newCard = Instantiate(cardPrefab, cardGridPanel);
                newCard.GetComponentInChildren<TextMeshProUGUI>().text = value + suit;
            }
        }
    }
}
