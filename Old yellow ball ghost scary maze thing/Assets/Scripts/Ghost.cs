using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Movement
{
    public GameObject body;
    public GameObject eyes;
    public GameObject blue;
    public GameObject white;
    public bool atHome;
    public float homeDuration;
    private bool frightened;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        body.SetActive(true);
        eyes.SetActive(true);
        blue.SetActive(false);
        white.SetActive(false);
        frightened = false;
        Invoke("LeaveHome", homeDuration);
    }

    protected override void ChildUpdate()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (atHome && collision.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
        {
            SetDirection(-direction);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Node node = collision.GetComponent<Node>();

        if(node != null)
        {
            int index = Random.Range(0, node.availableDirections.Count);


   
            if (node.availableDirections[index] == -direction)
            {
                index += 1;

                if(index == node.availableDirections.Count)
                {
                    index = 0;
                }

            }

            SetDirection(node.availableDirections[index]);
        }
    }

    private void LeaveHome()
    {
        transform.position = new Vector3(5.39f, 3.54f, -1.023971f);
        direction = new Vector2(-1, 0);
        atHome = false;
        frightened = false;
        body.SetActive(true);
        eyes.SetActive(true);
        blue.SetActive(false);
        white.SetActive(false);

    }

    public void Frighten()
    {

    }

    private void Flash()
    {

    }

    private void Reset()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
