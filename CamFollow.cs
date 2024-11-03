using UnityEngine;

public class KameraFollow : MonoBehaviour
{
    public Transform target; // Referensi objek bola yang akan diikuti
    public float distance = 5.0f; // Jarak horizontal antara kamera dan bola
    public float height = 3.0f; // Ketinggian kamera dari bola
    public float smoothSpeed = 0.125f; // Kecepatan smoothing kamera

    void LateUpdate()
    {
        if (target != null)
        {
            // Tentukan posisi yang diinginkan kamera berdasarkan posisi bola
            Vector3 desiredPosition = target.position - target.forward * distance + Vector3.up * height;
            
            // Interpolasi posisi kamera untuk pergerakan yang halus
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            
            // Mengarahkan kamera untuk selalu melihat ke arah bola
            transform.LookAt(target.position);
        }
    }
}
