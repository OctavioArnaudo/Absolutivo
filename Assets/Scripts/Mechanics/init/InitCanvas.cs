using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class InitCanvas : InitMixer
{
    public Dictionary<string, Canvas> menuPanelCanvas;
    public Canvas[] gamePlayCanvas;

    protected override void Awake()
    {
        base.Awake();
        menuPanelCanvas = new Dictionary<string, Canvas>
        {
            { "Game", gamePlayCanvas[0] },
            { "Levels", null },
            { "Options", null },
            { "Profile", null },
            { "Start", null },
            { "Stop", null },
            { "Worlds", null }
        };
    }

}