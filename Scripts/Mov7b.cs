using UnityEngine;

public class Mov7b : MonoBehaviour
{
    public Transform goal;
    public float speed;
    public float accuracy = 0.01f;

    void Update()
    {
        float distancia = Vector3.Distance(this.transform.position, goal.position);

        if (distancia > accuracy)
        {
            this.transform.LookAt(goal);

            Vector3 direction = goal.position - this.transform.position;

            this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
    }
}
