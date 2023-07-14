using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Boxcast = origin,size,angle,direction,
public abstract class Movement : MonoBehaviour
{
    public float speed;
    public Vector2 initialDirection;
    public LayerMask obstacleLayer;

    public Rigidbody2D rb;
    public Vector2 direction;
    public Vector2 nextDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = initialDirection;
        nextDirection = Vector2.zero;
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

    private void FixedUpdate()
    {
        Vector2 position = rb.position;
        Vector2 translation = direction * speed * Time.fixedDeltaTime;

        rb.MovePosition(position + translation);
    }

    private bool Occupied(Vector2 newDirection)
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector2.one * 0.5f, 0f, newDirection, 1.5f, obstacleLayer);
        return hit.collider != null;

    }

    protected void SetDirection(Vector2 newDirection)
    {
        if (!Occupied(newDirection))
        {
            direction = newDirection;
            nextDirection = Vector2.zero;
            Debug.Log(nextDirection);
            Debug.Log(direction);
            Debug.Log("A");
        }
        else
        {
            nextDirection = newDirection;
            Debug.Log(nextDirection);
            Debug.Log(direction);
            Debug.Log("B");
        }
    }
    abstract protected void ChildUpdate();

}
