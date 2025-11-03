using UnityEngine;

public class MovCubo : MonoBehaviour
{
    public float velocidad = 5.0f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        
        Vector3 movimiento = new Vector3(moveX, 0, moveZ);

        
        this.transform.Translate(movimiento * velocidad * Time.deltaTime, Space.World);
    }
}
