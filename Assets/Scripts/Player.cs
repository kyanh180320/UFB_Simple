using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float _gravityScale;

    private Rigidbody2D rb2d;
    [SerializeField] private float _thrust;
    public Transform _arrow;
    int checkwall;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame


    private void Update()
    {
        printf("hello");
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall Right"))
        {
            SetCheckWall(2);
            this.StatePlayerOnWall();
            transform.localScale = new Vector3(-1,1,1);

        }
        else if(collision.gameObject.CompareTag("Wall Left"))
        {
            SetCheckWall(1);
            this.StatePlayerOnWall();
            transform.localScale = new Vector3(1,1,1);
        }
        rb2d.isKinematic = false;
    }

    public void SetCheckWall(int value)
    {
        checkwall = value;
    }
    public int GetCheckWall()
    {
        return checkwall;
    }
    void StatePlayerOnWall()
    {
        rb2d.gravityScale = 0;
        rb2d.isKinematic = true;
        rb2d.velocity = Vector3.zero;
    }
    

}
