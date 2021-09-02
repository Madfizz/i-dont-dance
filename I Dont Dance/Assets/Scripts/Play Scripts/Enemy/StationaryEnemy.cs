using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryEnemy : BaseEnemy
{
    protected override void StopDancing()
    {
        // Code here for radius burst like a mine going off
        // Confetti blast
        base.StopDancing();
    }

}
