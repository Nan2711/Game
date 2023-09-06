using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 0.5f;
    public float turnspeed ;
    public float horizontalinput;
    public float verticalinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0,0,1); // 1 meter per frame 
      //  transform.Translate(Vector3.forward); 
      // transform.Translate(Vector3.forward *Time.deltaTime) // 1 meter per sec
        //transform.Translate(Vector3.forward *Time.deltaTime * 20); // 20 meter per sec
       // transform.Translate(Vector3.forward *Time.deltaTime * speed);
        horizontalinput = Input.GetAxis("Horizontal");
        verticalinput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.forward *Time.deltaTime * turnspeed);

        //transform.Translate(Vector3.right *Time.deltaTime * turnspeed * horizontalinput);

        transform.Rotate(Vector3.up ,Time.deltaTime * turnspeed * horizontalinput);
        transform.Translate(Vector3.forward *Time.deltaTime * turnspeed * verticalinput);
    }
}
