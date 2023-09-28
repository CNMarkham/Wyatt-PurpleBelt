using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{
    public float speedHorizantal;
    public float speed;
    private float previousTime;
    private float fallTime = 0.8f;
    public static float width = 10;
    public static float widthLeft = -5;
    public static float widthRight = 14;
    public static float height = -2;
    public Vector3 rotationPoint;
    public static Transform[,] grid = new Transform[width, height];
    // Start is called before the first frame updateS

    //do something james pls
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 convertedPoint = transform.TransformPoint(rotationPoint);
            transform.RotateAround(convertedPoint, Vector3.forward, 90);

            if (!ValidMove())
            {
                transform.RotateAround(convertedPoint, Vector3.forward, -90);
            }
        }
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
                gameObject.transform.position += Vector3.up;
                this.enabled = false;
                FindObjectOfType<Spawner>().SpawnTetromino();
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

            if (x >= widthRight)
            {
                return false;
            }



            if (y < -2)
            {
                return false;
            }

            if ((x <= widthLeft))
            {
                return false;
            }

        }

        return true;
    }
}

// || y <= height
