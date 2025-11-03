using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public Vector3 goal;

    void Start()
    {
        goal = goal * 0.5f;
    }

    void Update()
    {
        this.transform.Translate(goal);
    }
}
