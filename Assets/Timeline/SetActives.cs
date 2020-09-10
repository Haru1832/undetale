using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActives : MonoBehaviour
{
    private  int i;
    [SerializeField] private GameObject[] ActObj;
    
    [SerializeField] private GameObject[] NoActObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveSets()
    {
        for (i = 0; i < ActObj.Length; i++)
        {
            ActObj[i].SetActive(true);
        }
    }
    public void NoActiveSets()
    {
        for (i = 0; i < NoActObj.Length; i++)
        {
            NoActObj[i].SetActive(false);
        }
    }
}
