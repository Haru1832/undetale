using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class ScriptAnim : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject enemyHP;
    [SerializeField] private GameObject DamageText;
    private Image im;

    public Sprite[] sp;
    // Start is called before the first frame update
    void Start()
    {
        im = gameObject.GetComponent<Image>();
        //StartCoroutine(scriptAnim());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Playanim()
    {
        StartCoroutine(scriptAnim());
    }

    public IEnumerator scriptAnim()
    {
        int i;
        for (i = 0; i < sp.Length; i++)
        {
            im.sprite = sp[i];
            yield return new WaitForSeconds(0.07f);
        }
        //Destroy(gameObject);
        
        DamageText.SetActive(true);
        DamageText.GetComponent<PlayableDirector>().Play();
        enemyHP.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(enemyHP.GetComponent<EnemyHP>().decHPCorutin(Player.attack));
        //DamageText.GetComponent<DamaRece>().damaRece(damagevalue);
    }
}
