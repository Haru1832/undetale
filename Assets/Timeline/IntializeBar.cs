using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntializeBar : MonoBehaviour
{
    [SerializeField] private GameObject AttackBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetBar()
    {
        AttackBar.GetComponent<AttackBar>().setintialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
