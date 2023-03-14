using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHold : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _arrowLeft;
    public GameObject _arrowRight;
    public GameObject _playerLeft;
    public GameObject _playerRight;
   
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
       
    }
    public void ButtonClickedLeft()
    {
        //print("hold button");
        _playerLeft.GetComponent<Rigidbody2D>().gravityScale = 3f;
        _playerLeft.GetComponent<Rigidbody2D>().velocity = _arrowLeft.transform.right * 32;
        
        //if(_player.GetCheckWall() == 1 || _player.GetCheckWall() == 2)
        //{
        //    if(_arrow.activeInHierarchy == true)
        //    {
        //        _arrow.SetActive(false);
        //    }
        //    else _arrow.SetActive(true);
        //}
    }
    public void ButtonClickedRight()
    {
        _playerRight.GetComponent<Rigidbody2D>().gravityScale = 3f;
        _playerRight.GetComponent<Rigidbody2D>().velocity = _arrowRight.transform.right * 32;
    }
  
}
