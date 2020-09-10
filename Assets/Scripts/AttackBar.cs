using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class AttackBar : MonoBehaviour
{
    [SerializeField] private GameObject transformPoint;
    private bool _isPush;
    [SerializeField]private GameObject AttackEf;
    private float flashSpeed=0.1f;
    private bool isAttacked;
    [SerializeField]
    private float speed=0.08f;
    public Sprite[] sp;

    private float animTime = 6;

    private IEnumerator _enumerator;
    private ScriptAnim SA;

    // Start is called before the first frame update
    void Start()
    {
        _enumerator = FlashEffect();
        SA = AttackEf.GetComponent<ScriptAnim>();
        //gameObject.GetComponent<RectTransform>().DOMoveX(7, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            _isPush = true;
            StartCoroutine(_enumerator);
            SA.Playanim();
            
        }

        
        if (!_isPush)
        {
            Vector2 v2 = transform.position;
            v2.x += speed;
            gameObject.GetComponent<RectTransform>().transform.position = v2;

        }
    }

    public void setintialize()
    {
        _isPush = false;
        transform.position = transformPoint.transform.position;
    }
    
    public IEnumerator FlashEffect()
    {
        Image im = gameObject.GetComponent<Image>();
        StartCoroutine(counttime());
        while (true)
        { 
            Debug.Log("Alpha");
            im.sprite = sp[0];
            yield return new WaitForSeconds(flashSpeed);
            im.sprite = sp[1];
            
            yield return new WaitForSeconds(flashSpeed);
            
        }
        Destroy(gameObject);
    }

    public IEnumerator counttime()
    {
        yield return new WaitForSeconds(animTime);
        isAttacked = false;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "low": Player.attack = 8;
                break;
            case "normal": Player.attack = 12;
                break;
            case "high" : Player.attack = 15;
                break;
            default: Player.attack = 13;
                break;
        }
        Debug.Log("a");
    }
}
