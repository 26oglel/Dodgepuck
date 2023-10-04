using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private float xRange;
    public float yrange;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Keep Player Within xRange (Left and Right sides)
        if(transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange,transform.position.y);
        }
        
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        Debug.Log("moveHorizontal:" + moveHorizontal);

        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        transform.Translate(movement * speed * Time.deltaTime);

        //   if (Input.GetKeyDown(KeyCode.D))
        //{ 
        //}
    }
}
