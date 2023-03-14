using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
    Player player;

    float currentAngle = 0;
    [SerializeField] private GameObject _arrowPrefab;
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetCheckWall() == 1)
        {
            currentAngle = Mathf.PingPong(Time.time * _rotateSpeed, 180f) - 90;
            _arrowPrefab.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, currentAngle));
        }
        else if(player.GetCheckWall() == 2)
        {
            currentAngle = Mathf.PingPong(Time.time * _rotateSpeed, 180f) - 270;
            _arrowPrefab.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, currentAngle));
        }
        
        //this.ScaleArrow();
    }
        






}
