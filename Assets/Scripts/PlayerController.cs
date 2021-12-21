using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed;

    private float horizontalInput;
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }
}
