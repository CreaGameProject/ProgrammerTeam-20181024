﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    private SpriteManager spriteManager;
    protected int count;
    private int n;

    void Start()
    {
        spriteManager = new SpriteManager();
        if (SceneManager.GetSceneByName("Baseball").isLoaded)
        {
            PlayBaseBall();
        }
    }

    void Update()
    {

    }

    public void OnClick()
    {
        count++;

        n = count % 100;

        if (n == 0)
        {
            spriteManager.SpriteManage(count);
        }

        if (count == 510)
        {
            SceneManager.LoadScene("Baseball");
        }

        Debug.Log(count);
    }

    void PlayBaseBall()
    {

    }

}
