using System.Collections;
using System.Collections.Generic;
using UnityEngine;
                    
public class Pacman : Movement
    //inherits from this  ^
 //                       |
{
    protected override void ChildUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
     float vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0 || vertical != 0)
        {
            SetDirection(new Vector2(horizontal, vertical));
         //   Debug.Log(new Vector2(horizontal, vertical));
        }
        transform.right = direction;
    }
    // Start is called before the first frame update
  

    // Update is called once per frame
    //void Update()
    //{
    //    //if(nextDirection != Vector2.zero)
    //    //{
    //    //    SetDirection(nextDirection);
    //    //}

    //    //ChildUpdate();
    //}
}
