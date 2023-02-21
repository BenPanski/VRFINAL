using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SackAddHP : Sack
{
    public override void MySackFanc()
    {
        gamemanager.AddHP(Amount);
    }
}
