using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    private Slider slider;
    private float speed=10;

    [SerializeField]private GameObject Enemy;

    private Enemy pl;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        pl = Enemy.GetComponent<UruGhost>();
        slider.maxValue = pl.maxHP;
        slider.value = slider.maxValue;
    }

    public void decreaseHP(int damageValue)
    {
        StartCoroutine(decHPCorutin(damageValue));
    }

    public IEnumerator decHPCorutin(int damageValue)
    {
        int i;
        float onedamage = damageValue / speed;
        for (i = 0; i < speed; i++)
        {
            slider.value -= onedamage;
            pl.HP -= onedamage;
            yield return new WaitForSeconds(1/speed);
        }
        pl.HP= Mathf.Floor(pl.HP);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
