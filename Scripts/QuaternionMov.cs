using UnityEngine;

public class MQuaternionMov : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;
    public float rotationspeed = 2.0f;
    public float accuracy = 0.1f;

    void Update()
    {
        Vector3 directionToGoal = goal.position - this.transform.position;

        if (directionToGoal.magnitude > accuracy)
        {
            Vector3 currentDirection = this.transform.forward;
            Vector3 targetDirection = directionToGoal.normalized;

            Vector3 newDirection = Vector3.Slerp(
                currentDirection,
                targetDirection,
                rotationspeed * Time.deltaTime
            );

            this.transform.rotation = Quaternion.LookRotation(newDirection);

            this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}