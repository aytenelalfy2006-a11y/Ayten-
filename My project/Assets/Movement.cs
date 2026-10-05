using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    public float jumpHeight;

    public KeyCode Spacebar;
    public KeyCode L;
    public KeyCode R;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(Spacebar)){

            Jump();
        }
        
        if(Input.GetKey(L)){

            GetComponent<Rigidbody2D>().velocity
        }
    }
}
