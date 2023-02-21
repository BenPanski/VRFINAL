using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SackAddRock : Sack
{
    public override void MySackFanc()
    {
        gamemanager.AddRockAmount(Amount);
    }

 
}
