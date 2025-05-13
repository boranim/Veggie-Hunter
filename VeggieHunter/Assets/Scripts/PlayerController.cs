using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    Vector3 right = new Vector3(1, 0, 0);
    Vector3 forward = new Vector3(0, 0, 1);
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   



    // Update is called once per frame
    void Update()
    {


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        h = h * Time.deltaTime;
        v = v * Time.deltaTime;
        transform.Translate(right * h * speed);
        transform.Translate(forward * v * speed);

        if (Input.GetButton("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 5, 0));
        }


        /*
        float position2 = Input.GetAxis("Horizontal");
        position2 = position2 * speed * Time.deltaTime;
        transform.Translate(Vector3.right * position2);

      
        float position4 = Input.GetAxis("Vertical");
        position4 = position4 * speed * Time.deltaTime;
        transform.Translate(Vector3.up * position4);

        if (Input.GetButton("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 1, 0));
        }


        */


    }



    /* private void OnMouseDown()
     {
         int score;
         print("The score is" + score);
     }*/

    /*  int Sum(int num1, int num2)
      {
          int result;
          result = num1 + num2;
          return result;
      }*/

}
