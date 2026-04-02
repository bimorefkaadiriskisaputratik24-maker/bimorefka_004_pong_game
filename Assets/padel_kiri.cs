using UnityEngine;

public class padel_kiri : MonoBehaviour
{
    [Header("Pengaturan Paddle")]
    [SerializeField] private float kecepatan = 4f;
    [SerializeField] private float batasAtas = 4.5f;   // Sesuaikan dengan ukuran kameramu
    [SerializeField] private float batasBawah = -4.5f; // Sesuaikan dengan ukuran kameramu

    void Update()
    {
        float arahY = 0f;

        // Deteksi input W dan S
        if (Input.GetKey(KeyCode.W))
        {
            arahY = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            arahY = -1f;
        }

        Vector3 posisiBaru = transform.position + new Vector3(0, arahY * kecepatan * Time.deltaTime, 0);

        posisiBaru.y = Mathf.Clamp(posisiBaru.y, batasBawah, batasAtas);
        

        transform.position = posisiBaru;
    }
}