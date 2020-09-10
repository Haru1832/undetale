using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Damagaechase : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.FindWithTag("Player");
        StartCoroutine("randomchace");
    }

    public IEnumerator randomchace()
    {
        while (true)
        {
            gameObject.transform.DOMove(player.transform.position, 2.5f);
            yield return new WaitForSeconds(3.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
