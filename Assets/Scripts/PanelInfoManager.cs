using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;


public class PanelInfoManager : MonoBehaviour
{
    public Text Title;
    public GameObject Panel;

    public void Display(string title)
    {
        Title.text = title;

        Panel.SetActive(true);
    }

    public void Hide()
    {
        Panel.SetActive(false);
    }
}