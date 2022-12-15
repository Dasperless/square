using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float step;

    Rigidbody2D rb;
    
    [SerializeField] float jumpForce =10;

    
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        step = GetComponent<SpriteRenderer>().bounds.size.x;
    }


    



    // Update is called once per frame
    void Update()
    {
if (Input.GetKeyDown(KeyCode.UpArrow))
    {
        rb.AddForce(Vector2.up *jumpForce, ForceMode2D.Impulse);
    }

    }
}
