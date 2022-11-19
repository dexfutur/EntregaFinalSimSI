using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
  private MyVector position;
    [SerializeField] private MyVector acceleration;
    [SerializeField] private MyVector velocity;


    private MyVector a;
    private float b = 1;

    void Start()
    {
        position = new MyVector(transform.position.x, transform.position.y);
    }
    private void FixedUpdate()
    {
        Move();
    }

    void Update()
    {
        position.Draw(Color.blue);
        velocity.Draw(position, Color.red);
        acceleration.Draw(position, Color.green);


       b *= 1;
       a.y = acceleration.y;
       acceleration.y = a.y * b;
  
    }
    public void Move()
    {
        velocity = velocity + acceleration * Time.fixedDeltaTime;
        position = position + velocity * Time.fixedDeltaTime;

    
        transform.position = new Vector3(position.x, position.y);

    }
}
