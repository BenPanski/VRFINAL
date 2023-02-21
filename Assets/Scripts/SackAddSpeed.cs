using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SackAddSpeed : Sack
{
    
    public override void MySackFanc()
    {
        gamemanager.AddSpeed(Amount);
       
    }
}
