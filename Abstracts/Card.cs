using UnityEngine;
[System.Serializable]
public class Card
{
    public string cardName, cardType; // cardName = "number". card types: inicial, mercado, reserva
    public string[] cardSkills;
    /*
    extraAction, draw&Action, zeroMultiply, removeCard, shopWildcard
    */
    public int cardPoints; // this needs to be a positive number (2, 15, 23...)
    public char cardOperator; // this decides if the points above are suma (S), resta (R) or both +- (B)

    public Sprite illustration; // this needs to be assigned from folders
}
