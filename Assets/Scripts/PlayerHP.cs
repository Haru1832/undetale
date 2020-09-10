using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    private Slider slider;

    [SerializeField]private GameObject player;

    private Player pl;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        pl = player.GetComponent<Player>();
        slider.maxValue = pl.maxHP;
        slider.value = slider.maxValue;
    }

    public void decreaseHP(int damageValue)
    {
        slider.value -= damageValue;
    }

    public void healHP()
    {
        slider.value = slider.maxValue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
