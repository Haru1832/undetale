using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPtext : MonoBehaviour
{
    private Text text;
    [SerializeField] private GameObject HPtx;

    private Slider slider;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        slider = HPtx.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = slider.value + " / " + slider.maxValue;
    }
}
