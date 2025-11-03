using UnityEngine;

public class Mov7a : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;
    public float accuracy = 0.01f;

    void Update()
    {
        Vector3 direction = goal.position - this.transform.position;

        if (direction.magnitude > accuracy)
        {
            this.transform.LookAt(goal);
            this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
    }
}
