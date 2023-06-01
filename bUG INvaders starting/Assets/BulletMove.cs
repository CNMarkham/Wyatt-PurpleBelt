using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
                             //direction
            transform.Translate(Vector2.up * Time.deltaTime * speed);
       
    }
}
