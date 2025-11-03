using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;
    
    void Start()
    {
        this.transform.LookAt(goal.position);
    }

    
    void Update()
    {
        Vector3 direction = goal.position - this.transform.position;

        Debug.DrawRay(this.transform.position, direction, Color.red);

        this.transform.Translate(direction.normalized *speed*Time.deltaTime, Space.World);

        
    }
}
