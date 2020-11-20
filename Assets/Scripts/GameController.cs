﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text[] buttonList;

    private void Awake()
    {
        SetGameContollerReferenceOnButton();
    }

    void SetGameContollerReferenceOnButton()
    {
        for (int i = 0; i < buttonList.Length; i++)
        {
            buttonList[i].GetComponentInParent<GridSpaces>().SetGameControllerReference(this);
        }
    }

    public string GetPlayerSide()
    {
        return "?";
    }

    public void EndTurn()
    {
        Debug.Log("EndTurn is not implemented");
    }
}
