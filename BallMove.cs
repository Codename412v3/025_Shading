using UnityEngine;

public class BolaMaju : MonoBehaviour
{
    public float speed = 5.0f; // Kecepatan bola bergerak

    void Update()
    {
        // Gerakkan bola maju secara terus-menerus
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
