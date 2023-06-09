using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float moveX;
    [SerializeField] float moveZ;
    [Range(0,500)]
    [SerializeField] int moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");   
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveX,rb.velocity.y,moveZ) * moveSpeed * Time.deltaTime;
    }
}
