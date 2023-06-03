using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Asteroid : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle * speed;

        private void OnCollisionEnter2D(Collision2D collision)
    {
            SceneManager.LoadScene(0);
    }
}
}
