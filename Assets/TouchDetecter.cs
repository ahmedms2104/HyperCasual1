using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetecter : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                rb.AddForce(Vector2.up * 500);
                Debug.Log("hello");
            }
        }
    }
}