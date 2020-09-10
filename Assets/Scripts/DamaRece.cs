using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamaRece : MonoBehaviour
{
    private Text tx;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        tx = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tx.text = "" + Player.attack;
    }
}
