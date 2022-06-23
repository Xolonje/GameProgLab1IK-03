using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtState : BaseState
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
        if(p.Lives == 0) owner.ChangeState(new GameOverState());
        else owner.ChangeState(new NormalState());
    }
}
