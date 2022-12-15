using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float step;
    private float moveHorizontal;
    Rigidbody2D rb;
    
    [SerializeField] float jumpForce =10;

    
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        step = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.CompareTag("Lava")){
            transform.position = new Vector3(0,0,0);
        }else if(collision.gameObject.CompareTag("Puerta")){
            Destroy(collision.gameObject);
        }

    



    // Update is called once per frame
    void Update(){
        moveHorizontal =Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.UpArrow))
    {
        rb.AddForce(Vector2.up *jumpForce, ForceMode2D.Impulse);
    }
    FixedUpated();
    }
    
    

void FixedUpated()
    {
if (moveHorizontal >0.1f || moveHorizontal < -0.1f){
    rb.AddForce(new Vector2( moveHorizontal*step, 0f),ForceMode2D.Impulse);
}
    }
}
