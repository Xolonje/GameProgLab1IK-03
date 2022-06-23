using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalState : BaseState
{
    public Player p;
    public override void PrepareState()
    {
        base.PrepareState();
        p = owner.GetComponent<Player>();
    }

    public override void UpdateState()
    {
        base.UpdateState();
        if(p.Lives==p.Lives-1) owner.ChangeState(new HurtState());
    }
}
