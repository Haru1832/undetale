using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterCha : MonoBehaviour
{
    [SerializeField] private GameObject ActT;
    [SerializeField] private GameObject NoActT;
    [SerializeField] private GameObject BeforeActT;
    [SerializeField] private GameObject BeforeActC;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            NoActT.SetActive(false);
            ActT.SetActive(true);
        

            if (gameObject.CompareTag("Command"))
            {
                this.gameObject.GetComponentInParent<WindowChange>()._ChangeNoActive();
            }
        }

        if (BeforeActT == null) return;
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            NoActT.SetActive(false);
            BeforeActC.SetActive(true);
            TextController _te=BeforeActC.GetComponent<TextController>();
            //_te.intializetext();
            _te.SetNextSentence();


            if (BeforeActT.CompareTag("Command"))
            {
                BeforeActT.gameObject.GetComponentInParent<WindowChange>()._ChangeActive();
            }

        }
    }
}