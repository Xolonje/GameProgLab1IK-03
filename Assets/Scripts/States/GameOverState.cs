using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class GameOverState : BaseState
{
    // Start is called before the first frame update
    public Player p;
    public override void PrepareState()
    {
        base.PrepareState();
        SceneManager.LoadScene("GameOver");
    }

    public override void UpdateState()
    {
        base.UpdateState();
        SceneManager.LoadScene("GameOver");
    }
}
