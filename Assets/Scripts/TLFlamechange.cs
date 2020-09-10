using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TLFlamechange : MonoBehaviour
{
    [SerializeField] private GameObject FlameC;
    [SerializeField] private GameObject Serihu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void UseFlameC()
    {
        Serihu.GetComponent<laterfalse>().laterset();
        FlameC.GetComponent<ChangeTextScale>().ChangeSmall();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
