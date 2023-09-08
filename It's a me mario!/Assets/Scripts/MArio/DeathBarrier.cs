using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBarrier : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {            
            Invoke("ResetScene", 2f);
        
        }
        else
        {
            Destroy(collision.gameObject);
            Debug.Log(collision.name);

        }
    }

    private void ResetScene()
    {
        
        SceneManager.LoadScene(0);
    }
}
