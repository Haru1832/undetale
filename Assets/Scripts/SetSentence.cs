using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSentence : MonoBehaviour
{
    private int i;
    [SerializeField] private GameObject[] Maintext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void settexts()
    {
        for (i = 0; i < Maintext.Length; i++)
        {
            Maintext[i].GetComponent<TextController>().currentSentenceNum++;
            Maintext[i].GetComponent<TextController>().SetNextSentence();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
