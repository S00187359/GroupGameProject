using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PathNode CurrentNode;
    bool shouldMove = true;
    float mouseX;
   
    public float rotationSpeed = 2;
    
    Vector3 direction;

    

    private void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        if (shouldMove)
        {
            direction = CurrentNode.transform.position - transform.position;
            transform.position += direction.normalized * CurrentNode.Speed * Time.deltaTime;
            //transform.forward = direction;

            mouseX = Input.GetAxisRaw("Mouse X");
           

            //rotate on the Y axis
            transform.Rotate(Vector3.up, mouseX * rotationSpeed * Time.deltaTime);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       

        if (other.gameObject.CompareTag("PathNode") && other.gameObject.name == CurrentNode.name)
        {
            PathNode node;

            if (other.TryGetComponent<PathNode>(out node))
            {
                if (node.NextNode != null)
                    CurrentNode = node.NextNode;
                else
                    shouldMove = false;
            }
        }
    }
}
