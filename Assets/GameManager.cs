using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    private int skorKiri = 0;
    private int skorKanan = 0;
    private int batasMenang = 11; // Syarat menang di poin 11

    [SerializeField] private TextMeshProUGUI teksSkorKiri;
    [SerializeField] private TextMeshProUGUI teksSkorKanan;
    
    // TAMBAHAN: Kita bikin slot buat masukin script bola ke sini
    [SerializeField] private Padel_Ball scriptBola; 

    void Start()
    {
        // PENTING: Kembalikan waktu berjalan normal (1) setiap kali game di-play.
        Time.timeScale = 1f; 
    }

    public void SkorKiriBertambah()
    {
        skorKiri++;
        
        if (skorKiri >= batasMenang)
        {
            teksSkorKiri.text = "WIN";
            teksSkorKanan.text = "LOSE";
            Time.timeScale = 0f; // Bekukan waktu game (Game Over)
        }
        else
        {
            teksSkorKiri.text = skorKiri.ToString();
            
            // Panggil fungsi ResetBall yang ada di script Padel_Ball
            if(scriptBola != null) 
            {
                scriptBola.ResetBall(); 
            }
        }
    }

    public void SkorKananBertambah()
    {
        skorKanan++;
        
        if (skorKanan >= batasMenang)
        {
            teksSkorKanan.text = "WIN";
            teksSkorKiri.text = "LOSE";
            Time.timeScale = 0f; // Bekukan waktu game (Game Over)
        }
        else
        {
            teksSkorKanan.text = skorKanan.ToString();
            
            // Panggil fungsi ResetBall yang ada di script Padel_Ball
            if(scriptBola != null) 
            {
                scriptBola.ResetBall(); 
            }
        }
    }
}