using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHP;
    public int Hp;
    public bool isDamage;
    public static int attack;
    [SerializeField] private float invisibleTime=5;
    [SerializeField] private float flashSpeed=0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        attack = 13;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    public void Damaged(int damageValue)
    {
        if (isDamage) return;
        StartCoroutine(damageEffect());
        Hp -= damageValue;
        isDamage = true;
    }

    public void Healed(int healValue)
    {
        Hp += healValue;
    }

    public IEnumerator damageEffect()
    {
        Image im = gameObject.GetComponent<Image>();
        StartCoroutine(counttime());
        while (true)
        { 
            Debug.Log("Alpha");
            im.color = new Color(1,1,1,0.5f);
            yield return new WaitForSeconds(flashSpeed);
            im.color = new Color(1,1,1,1.0f);
            if (!isDamage) break;
            yield return new WaitForSeconds(flashSpeed);
            
        }
    }

    public IEnumerator counttime()
    {
        yield return new WaitForSeconds(invisibleTime);
        isDamage = false;
    }
    
    
}