using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public PanelInfoManager PanelInfo;

    void Awake()
    {
        PanelInfo.Hide();
    }

    public void Play()
    {
        // todo
    }

    public void DisplayRules()
    {
        PanelInfo.Display("RULES");
    }

    public void DisplayOptions()
    {
        PanelInfo.Display("OPTIONS");
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}