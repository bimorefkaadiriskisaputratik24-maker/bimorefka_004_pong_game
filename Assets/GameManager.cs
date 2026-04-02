using UnityEngine;
using TMPro; // Kita pakai TextMeshPro biar teksnya tajam

public class GameManager : MonoBehaviour
{
private int skorKiri = 0;
private int skorKanan = 0;

[SerializeField] private TextMeshProUGUI teksSkorKiri;
[SerializeField] private TextMeshProUGUI teksSkorKanan;
    // Fungsi untuk nambah skor kiri
    public void SkorKiriBertambah()
    {
        skorKiri++;
        teksSkorKiri.text = skorKiri.ToString();
        ResetBola();
    }

    // Fungsi untuk nambah skor kanan
    public void SkorKananBertambah()
    {
        skorKanan++;
        teksSkorKanan.text = skorKanan.ToString();
        ResetBola();
    }

    void ResetBola()
    {
        // Kodingan yang benar
        GameObject.Find("Circle").GetComponent<Padel_Ball>().ResetBall();
    }
}