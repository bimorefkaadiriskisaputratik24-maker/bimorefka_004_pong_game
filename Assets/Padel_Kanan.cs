using UnityEngine;

public class PadelKomputer : MonoBehaviour
{
    [Header("Pengaturan AI")]
 [SerializeField] private Transform bola;
[SerializeField] private float kecepatan = 4f;
    void Update()
    {
        if (bola != null)
        {

            Vector2 targetPosisi = new Vector2(transform.position.x, bola.position.y);
            
            transform.position = Vector2.MoveTowards(transform.position, targetPosisi, kecepatan * Time.deltaTime);
        }
        else
        {
            Debug.LogWarning("Objek Bola belum dimasukkan ke script PadelKomputer!");
        }
    }
}