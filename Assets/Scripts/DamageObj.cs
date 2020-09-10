using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObj : MonoBehaviour
{
    [SerializeField] private int damageValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        if (other.gameObject.GetComponent<Player>().isDamage) return;
        GameObject plhp = GameObject.FindWithTag("PLHP");
        plhp.GetComponent<PlayerHP>().decreaseHP(damageValue);
        other.gameObject.GetComponent<Player>().Damaged(damageValue);
        //Destroy(this.gameObject);
    }
}
