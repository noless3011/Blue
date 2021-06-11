using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    // Start is called before the first frame update
    public float force = 5.0f;
    public float torque = 5.0f;
    private GameObject obj ;
    private Rigidbody2D rb;
    void Start()
    {
        obj = this.gameObject;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane;
            Vector2 direction = new Vector2(mousePos.x - Screen.width/2, mousePos.y - Screen.height/2);
            rb.AddForce(-direction.normalized*force, ForceMode2D.Impulse);
        }
        if(Input.GetKey(KeyCode.E)){
            rb.AddTorque(torque);
        }
        if(Input.GetKey(KeyCode.Q)){
            rb.AddTorque(-torque);
        }
        
    }
    private void OnCollisionEnter(Collision other) {
        Vector2 currentSpeed = rb.velocity.normalized;
        // if ((currentSpeed.x + currentSpeed.y) > -1000)
        
        Debug.Log(currentSpeed.x + currentSpeed.y);
        
    }
    
}
