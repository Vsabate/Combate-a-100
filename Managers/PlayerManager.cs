using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singleton
    public static PlayerManager instance;
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

    public List<Player> playerList = new List<Player>();

    internal void AssignTurn(int currentPlayerTurn)
    {
        Player plr = playerList.Find(x => x.ID == currentPlayerTurn);
        plr.myTurn = true;
    }
}
