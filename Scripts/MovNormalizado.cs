using UnityEngine;

public class MovNormalizado : MonoBehaviour
{
    public Vector3 goal;
    public float speed;

    void Update()
    {
        
        this.transform.Translate(goal.normalized * speed * Time.deltaTime);
    }
}