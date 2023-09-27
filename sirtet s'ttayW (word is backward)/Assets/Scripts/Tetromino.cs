using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{
    public float speedHorizantal;
    public float speed;
    private float previousTime;
    private float fallTime = 0.8f;
    public static float widthLeft = -5;
    public static float widthRight = 14;
    public static float height = -2;
    // Start is called before the first frame updateS


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObject.transform.position += Vector3.right;//* Time.deltaTime * speedHorizantal;

            if (!ValidMove())
            {
                gameObject.transform.position += Vector3.left; //* Time.deltaTime * speedHorizantal;

            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.transform.position += Vector3.left; //* Time.deltaTime * speedHorizantal;


            if (!ValidMove())
            {
                gameObject.transform.position += Vector3.right; //* Time.deltaTime * speedHorizantal;

            }
        }

        

        float tempTime = fallTime;      
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tempTime = tempTime / 10;
        }

        if (Time.time - previousTime > tempTime)
        {
            transform.position += Vector3.down;
            previousTime = Time.time;

            if (!ValidMove())
            {
                gameObject.transform.position += Vector3.down;
            }
        }
 

       //ValidMove();
    }

    public bool ValidMove()
    {
        foreach (Transform child in transform)
        {
            int x = Mathf.RoundToInt(child.transform.position.x);
            int y = Mathf.RoundToInt(child.transform.position.y);

            Debug.Log("X positin: " + x);
        if(x < widthLeft)           
                { 

                return  false;
            }

            if ((x >= widthRight || y <= height))
            {
                return false;
            }



      //      if ((x < 0 || y < 0))
        //    {
        //        return false;
          //  }

            if ((x <= widthLeft || y <= height))
            {
                return false;
            }

        }

        return true;
    }
}
