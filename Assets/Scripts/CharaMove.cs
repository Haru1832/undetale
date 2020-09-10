using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaMove : MonoBehaviour
{
    private float player_x;
    private float player_y;
    private float x = 0;
    private float y = 0;
    private float pos_x;
    private float pos_y;
    [SerializeField]
    private RectTransform[] rect;

    private RectTransform _chataTransform;
    // Start is called before the first frame update
    void Start()
    {
        _chataTransform = gameObject.GetComponent<RectTransform>();
//        pos_x = _chataTransform.transform.position.x;
//        pos_y = _chataTransform.transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        
        x=Input.GetAxis("Horizontal");
        y=Input.GetAxis("Vertical");
        player_x = gameObject.transform.position.x + x/50;
        player_y = gameObject.transform.position.y + y/50;
        
        //if (judgemove()) return;
        
        _chataTransform.position=new Vector3(Mathf.Clamp(player_x,rect[1].position.x,rect[0].position.x),Mathf.Clamp(player_y,rect[1].position.y,rect[0].position.y),0);
    }

//    private bool judgemove()
//    {
//        if ((rect[0].position.x + (x) < _chataTransform.position.x ||
//             rect[1].position.x + (x) > _chataTransform.position.x) ||
//            rect[0].position.y + (y) < _chataTransform.position.y ||
//            rect[1].position.y + (y) > _chataTransform.position.y)
//        {
//            x = 0;
//            y = 0;
//            return true;
//        }
//            
//
//        return false;
//    }
}
