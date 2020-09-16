using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Referee_Test_Tap100times : RefereeBaseClass
{
    int tapCount = 0;

    public bool isClear = false;

    protected override void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            tapCount++;
        }

        base.Update();
    }

    public override bool Judgment()
    {
        if (tapCount >= 100)
            return true;
        else
            return false;
    }

    /// <summary>
    /// If you feel hard to watch the gameclear, you should commentout this, and release the comments under this function. 
    /// </summary>
    public override void GameClear()
    {
        isClear = true;
    }

//    public override void GameClear()
//    {
//        Quit();
//    }

//    void Quit()
//    {
//#if UNITY_EDITOR
//        UnityEditor.EditorApplication.isPlaying = false;
//#elif UNITY_STANDALONE
//        UnityEngine.Application.Quit();
//#endif
//    }
}
