using UnityEngine;
[System.Serializable]
public class Player
{
    public int ID;
    public int score;
    public bool myTurn;

    public Player(int ID, int score, bool myTurn)
    {
        this.ID = ID;
        this.score = score;
        this.myTurn = myTurn;
    }
}
