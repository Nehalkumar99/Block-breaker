using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    void Update()
    {
        //  Debug.Log(Input.mousePosition);

        Vector2 paddlePos=new Vector2(Input.mousePosition.x / Screen.width * 16,transform.position.y);
        if (paddlePos.x <= 0)
            paddlePos.x = 0;
        if (paddlePos.x >= 16)
            paddlePos.x = 16;

        transform.position = paddlePos;
    }
}
