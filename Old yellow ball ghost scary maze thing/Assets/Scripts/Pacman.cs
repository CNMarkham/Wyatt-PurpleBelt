using System.Collections;
using System.Collections.Generic;
using UnityEngine;
                    
public class Pacman : Movement
    //inherits from this  ^
 //                       |
{
    protected override void ChildUpdate()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nextDirection != Vector2.zero)
        {
            SetDirection(nextDirection);
        }

        ChildUpdate();
    }
    abstract protected void ChildUpdate();
}
