using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowChange : MonoBehaviour
{
    [SerializeField] private GameObject ActiveC;
    [SerializeField] private GameObject NoActiveC;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void _ChangeActive()
    {
        ActiveC.SetActive(true);
        NoActiveC.SetActive(false);
    }
    
    public void _ChangeNoActive()
    {
        ActiveC.SetActive(false);
        NoActiveC.SetActive(true);
    }
    
}
