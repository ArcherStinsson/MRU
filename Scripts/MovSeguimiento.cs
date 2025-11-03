using UnityEngine;

public class MovSeguimiento : MonoBehaviour
{
    public Transform goal;
    public float speed;
    public float faster;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            speed = speed + faster;
        }
       
        this.transform.LookAt(goal.position);

        
        Vector3 direction = goal.position - this.transform.position;

        
        this.transform.Translate(direction.normalized * speed *Time.deltaTime, Space.World);
    }
}
