using UnityEngine;

public class Padel_Kanan : MonoBehaviour
{
    [Header("Pengaturan AI")]
    public Transform bola;           // Tempat untuk mendeteksi posisi bola
    public float speed = 5f;         // Kecepatan AI (jangan terlalu cepat biar bisa dikalahin)
    public float batasAtas = 4.5f;   // Disesuaikan dengan tembok atas
    public float batasBawah = -4.5f; // Disesuaikan dengan tembok bawah

    void Update()
    {
        // Jaga-jaga kalau bola belum dimasukkan di Unity agar tidak error
        if (bola == null) return;

        // Cari tahu posisi Y (naik-turun) bola saat ini
        float targetY = bola.position.y;
        float posisiY_Sekarang = transform.position.y;

        // Komputer menggerakkan paddle secara mulus mengejar Y bola
        float gerakY = Mathf.MoveTowards(posisiY_Sekarang, targetY, speed * Time.deltaTime);

        // Kunci posisi agar AI tidak keluar dari batas layar/tembok
        gerakY = Mathf.Clamp(gerakY, batasBawah, batasAtas);
        
        // Terapkan posisi baru ke paddle kanan
        transform.position = new Vector3(transform.position.x, gerakY, transform.position.z);
    }
}