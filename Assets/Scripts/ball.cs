using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    [SerializeField] float launchSpeed;
    Vector2 paddleToBallDistance;
    bool isLaunched = false;
    void LaunchBall()
    {
        isLaunched = true;
        GetComponent<Rigidbody2D>().velocity = new Vector2(2f, launchSpeed);
    }

    void Start()
    {
        paddleToBallDistance = transform.position - paddle1.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLaunched)
        {
            Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
            transform.position = paddlePos + paddleToBallDistance;
            if(Input.GetMouseButtonDown(0))
            {
                LaunchBall();
            }
        }

    }
}
