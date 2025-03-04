using UnityEngine;

public class orbit : MonoBehaviour
{
    public Transform centerPoint; 
    public float radius = 5f;     
    public float speed = 2f;      

    private float angle;

    void Update()
    {
        angle += speed * Time.deltaTime; 

        
        float x = centerPoint.position.x + Mathf.Cos(angle) * radius;
        float z = centerPoint.position.z + Mathf.Sin(angle) * radius;

        Vector3 newPosition = new Vector3(x, transform.position.y, z);
 
        Vector3 direction = newPosition - transform.position;
        if (direction != Vector3.zero)
        {
            transform.forward = direction.normalized; 
        }

        
        transform.position = newPosition;
    }
}
