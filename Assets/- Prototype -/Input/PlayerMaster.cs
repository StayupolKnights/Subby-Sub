﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaster : MonoBehaviour
{
    public PlayerID playerID;
    
    public PlayerInfo LoadPlayer()
    {
        return LocalPlayers.GetPlayer(playerID);
    }
}
