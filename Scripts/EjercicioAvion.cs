using UnityEngine;

public class EjercicioAvion : MonoBehaviour
{
    public float velocidadAvance;
    public float velocidadDespegue;

    void Update()
    {
        Vector3 movimiento = new Vector3(0, velocidadDespegue, velocidadAvance);

        this.transform.Translate(movimiento);
    }
}
