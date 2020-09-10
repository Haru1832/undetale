using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChangeTextScale : MonoBehaviour
{
    [SerializeField] private GameObject rightF;
    [SerializeField] private GameObject leftF;

    [SerializeField] private float transvalue;
    [SerializeField] private float speed=3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSmall()
    {
        rightF.GetComponent<RectTransform>().DOMoveX(transvalue, speed).SetRelative();
        leftF.GetComponent<RectTransform>().DOMoveX(-transvalue, speed).SetRelative();
    }
    
    public void Changebig()
    {
        rightF.GetComponent<RectTransform>().DOMoveX(-transvalue, speed).SetRelative();
        leftF.GetComponent<RectTransform>().DOMoveX(transvalue, speed).SetRelative();
    }
    
}
