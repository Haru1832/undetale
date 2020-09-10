using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class laterfalse : MonoBehaviour
{

    [SerializeField] private GameObject[] Event;

    private int i=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void laterset()
    {
        Invoke(nameof(settingfalse),2);
    }

    public void settingfalse()
    {
        
        Event[i].GetComponent<PlayableDirector>().Play();
        i++;
        gameObject.SetActive(false);
    }
}
