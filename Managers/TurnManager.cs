using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    #region Singleton
    public static TurnManager instance;
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

    public int currentPlayerTurn;

    #region FUNCTIONS
    public void StartTurnGameplay(int playerID)
    {
        currentPlayerTurn = playerID;
        PlayerManager.instance.AssignTurn(currentPlayerTurn);
    }
    public void StartTurn()
    {

    }
    public void EndTurn()
    {

    }
    #endregion
}
