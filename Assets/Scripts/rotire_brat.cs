using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotire_brat : MonoBehaviour
{
    public static float movementXx=0;
    public static float speedx=0;
    public static float movementYx=0;
    Vector2 mousePos;
    public Camera cam;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90f;
        rb.rotation = angle;
    }
}
