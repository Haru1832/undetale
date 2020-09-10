using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class UruGhost : Enemy
{

    UruGhost()
    {
        maxHP = 50;
        HP = maxHP;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            GetComponent<SetActives>().ActiveSets();
            GetComponent<SetActives>().NoActiveSets();
            fadeout();
        }
    }

    private void fadeout()
    {
        var fadeImage = GetComponent<Image>();
    fadeImage.enabled = true;
    var c = fadeImage.color;
    c.a = 1.0f; // 初期値
    fadeImage.color = c;

    DOTween.ToAlpha(
    ()=> fadeImage.color,
    color => fadeImage.color = color,
    0f, // 目標値
    0.5f // 所要時間
    );
    }
}
