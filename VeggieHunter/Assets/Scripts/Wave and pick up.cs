using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waveandpickup : MonoBehaviour
{

    protected Animator mAvatar;
    // Start is called before the first frame update
    void Start()
    {
        mAvatar = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            mAvatar.SetTrigger("Wave");
        }
        if (Input.GetKey(KeyCode.Q))
        {
            mAvatar.SetTrigger("Pickup");
        }
    }
    // Start is called before the first frame update
  
}
