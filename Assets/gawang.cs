using UnityEngine;

public class Gawang : MonoBehaviour
{
    [SerializeField] private bool iniGawangKiri; // Centang di Inspector kalau ini gawang kiri

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Circle") // Jika yang nabrak adalah bola
        {
            GameManager gm = GameObject.Find("GameManager").GetComponent<GameManager>();

            if (iniGawangKiri)
            {
                // Kalau masuk gawang kiri, berarti poin buat Padel Kanan (AI)
                gm.SkorKananBertambah();
            }
            else
            {
                // Kalau masuk gawang kanan, berarti poin buat Padel Kiri (Player)
                gm.SkorKiriBertambah();
            }
        }
    }
}