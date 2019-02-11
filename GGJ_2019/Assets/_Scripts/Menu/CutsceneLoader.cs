﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

public class CutsceneLoader : MonoBehaviour
{
    public Image Cutscene_image;

    public Image NextButton_image;
    public Image PrevButton_image;

    public Text NextButton_text;
    public Text PrevButton_text;

    public Sprite[] Cutscene_Sprite;

    public int Cutscene_Num = 0;
    public int Cutscene_Num_Max = 5;

    private bool played = false;

    // Use this for initialization
    void Awake()
    {

        Cutscene_Num = 0;
        Cutscene_Num_Max = Cutscene_Sprite.Length - 1;
    }

    //Go to Next Cutscene
    public void NextButton()
    {
        if (Cutscene_Num < Cutscene_Num_Max)
        {
            Cutscene_Num++;
        }
    }

    //Go to Previous Cutscene
    public void PrevButton()
    {
        if (Cutscene_Num > 0)
        {
            Cutscene_Num--;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("NextCutscene"))
        {
            NextButton();
        }
        if (Input.GetButtonDown("PrevCutscene"))
        {
            PrevButton();
        }

        Cutscene_image.sprite = Cutscene_Sprite[Cutscene_Num];

        //Change button if they reach end of slideshows
        if (Cutscene_Num == Cutscene_Num_Max)
        {
            NextButton_image.enabled = false;
            NextButton_text.enabled = false;

            if (!played)
            {
                played = true;
            }
        }
        else
        {
            NextButton_image.enabled = true;
            NextButton_text.enabled = true;
        }
        if (Cutscene_Num == 0)
        {
            PrevButton_image.enabled = false;
            PrevButton_text.enabled = false;
        }
        else
        {
            PrevButton_image.enabled = true;
            PrevButton_text.enabled = true;
        }

    }
}
