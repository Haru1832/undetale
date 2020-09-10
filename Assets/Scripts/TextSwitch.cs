using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSwitch : MonoBehaviour
{
    [SerializeField] private GameObject rightObj;
    [SerializeField] private GameObject leftObj;
    private WindowChange _win;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (rightObj != null)
            {
                _win = rightObj.GetComponent<WindowChange>();
                _win._ChangeActive();
                WindowChange nowwin = GetComponentInParent<WindowChange>();
                nowwin._ChangeNoActive();
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (leftObj != null)
            {
                _win = leftObj.GetComponent<WindowChange>();
                _win._ChangeActive();
                WindowChange nowwin = GetComponentInParent<WindowChange>();
                nowwin._ChangeNoActive();
            }
        }
    }
}