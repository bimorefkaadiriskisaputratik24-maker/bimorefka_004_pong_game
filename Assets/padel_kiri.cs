using UnityEngine;

public class padel_kiri : MonoBehaviour
{
    [Header("Pengaturan Paddle")]
    public float speed = 10f;
    public float batasAtas = 4.5f;   // Sesuaikan dengan ukuran kameramu
    public float batasBawah = -4.5f; // Sesuaikan dengan ukuran kameramu

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

        // Hitung pergerakan
        Vector3 posisiBaru = transform.position + new Vector3(0, arahY * speed * Time.deltaTime, 0);

        // Kunci posisi agar tidak keluar batas atas/bawah layar
        posisiBaru.y = Mathf.Clamp(posisiBaru.y, batasBawah, batasAtas);
        
        // Terapkan posisi baru ke paddle
        transform.position = posisiBaru;
    }
}