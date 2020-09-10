using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhatHPbar : MonoBehaviour
{
    private GameObject enemy;
    private UruGhost uru;

    private Slider sl;
    // Start is called before the first frame update
    void Start()
    {
        enemy= GameObject.Find("Enemy");
        uru = enemy.GetComponent<UruGhost>();
        sl = GetComponent<Slider>();
        
        sl.maxValue = uru.maxHP;
        sl.value = uru.HP;
    }

    // Update is called once per frame
    void Update()
    {
        sl.value =uru.HP;
    }
}
