using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10f;

    Rigidbody2D body;
    public float horizontal;
    public float vertical;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

    }

    //Fixed Update is called 50 times per second / Anv�nds f�r fysik och �r j�mn f�r alla datorer. Fixed movement
    private void FixedUpdate() 
    {
        body.velocity = new Vector2 (horizontal * (speed), vertical * speed);
    }


}
