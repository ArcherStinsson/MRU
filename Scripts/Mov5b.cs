using UnityEngine;

public class Mov5b : MonoBehaviour
{
    public Transform goal;
    public float speed;

    void Update()
    {
        this.transform.LookAt(goal);

        Vector3 direction = goal.position - this.transform.position;

        this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.Self);
    }
}