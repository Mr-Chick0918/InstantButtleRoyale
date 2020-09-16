using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefereeBaseClass : MonoBehaviour
{
    public enum RefereeingStyle
    {
        FOR_OVER  = 0,
        FOR_CLEAR = 1,
    }

    /// <summary>
    /// If you want the free timing for Refereeing, you should set "false".
    /// </summary>
    [SerializeField]
    bool autoRefereeing = true;

    /// <summary>
    /// If the game need refereeing for gameover, example the survival, you should set "FOR_OVER".
    /// </summary>
    [SerializeField]
    RefereeingStyle style = RefereeingStyle.FOR_CLEAR;

    // Update is called once per frame
    protected virtual void Update()
    {
        if (autoRefereeing)
            Refereeing();
    }

    public void Refereeing()
    {
        if(style != RefereeingStyle.FOR_OVER)
        {
            if (Judgment())
                GameClear();
        }
        else
        {
            if (Judgment())
                GameOver();
        }
    }

    public virtual bool Judgment()
    {
        return false;
    }

    public virtual void GameClear()
    {

    }

    public virtual void GameOver()
    {

    }
}
