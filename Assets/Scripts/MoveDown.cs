using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private float speed = 2f;
    private float minLimY = -1f;
    
    void update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);

        if (transform.position.y < minLimY)
        {
            Time.timeScale = 0;
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        }
    }
    
    
}
