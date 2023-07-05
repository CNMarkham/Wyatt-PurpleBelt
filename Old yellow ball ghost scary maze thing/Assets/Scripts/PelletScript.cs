using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("active");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pacman"))
        {
            print("i am working!");
            Eat();
        }
    }

            protected virtual void Eat()
    {
        gameObject.SetActive(false);
    }
}

