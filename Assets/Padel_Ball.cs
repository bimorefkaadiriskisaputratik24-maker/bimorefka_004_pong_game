using UnityEngine;

public class Padel_Ball : MonoBehaviour
{
    [SerializeField] private float speed = 300f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ResetBall();
    }

    public void ResetBall()
    {
        transform.position = Vector2.zero;
        rb.linearVelocity = Vector2.zero;
        
        Invoke(nameof(Launch), 1f); 
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        
        Vector2 direction = new Vector2(x, y).normalized;
        rb.AddForce(direction * speed);
    }
}