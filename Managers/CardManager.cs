using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    #region Singleton
    public static CardManager instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    #endregion

    public List<Card> cards = new List<Card>();
    public Transform p1_hand, p2_hand;
    public CardController cc_prefab;

    private void Start()
    {
        GenerateHand_Turn1();
    }




    private void GenerateHand_Turn1()
    {
        // randomly draw 2 cards for "turn-1 player" and 4 cards for "turn-2 player"
        foreach (Card c in cards)
        {
            CardController newCard = Instantiate(cc_prefab, p1_hand);
            newCard.transform.localPosition = Vector3.zero;
            newCard.Initialize(c);
        }
    }
}
