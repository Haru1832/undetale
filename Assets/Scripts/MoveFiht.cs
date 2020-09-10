using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFiht : MonoBehaviour
{
    public GameObject Serihu;
    public GameObject player;
    public GameObject HPbar;
    public GameObject ChangeFlame;
    // Start is called before the first frame update
    void Start()
    {
        HPbar.GetComponent<PlayerHP>().healHP();
       Invoke(nameof(laterfight),1.5f);
    }

    private void laterfight()
    {
        Serihu.GetComponent<laterfalse>().laterset();
        ChangeFlame.GetComponent<ChangeTextScale>().ChangeSmall();
        player.SetActive(true);
        gameObject.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        
            
    }
}
