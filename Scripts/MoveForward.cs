using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public Transform goal;
    public float speed;

    void Update()
    {
        
        this.transform.LookAt(goal);

       
        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}