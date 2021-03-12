using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody body;
    float horizontal;
    float vertical;
    public float runSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start");
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector3(horizontal * runSpeed, 0, vertical * runSpeed);
    }
}
