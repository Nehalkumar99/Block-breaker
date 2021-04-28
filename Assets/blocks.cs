using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocks : MonoBehaviour
{
    level level;
    private void Start()
    {
        level = FindObjectOfType<level>();
        level.countBreakableBlocks();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        level.countBrokenBlocks();
        FindObjectOfType<GameStatus>().addScore();
    }
}
