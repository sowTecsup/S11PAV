using UnityEngine;

public class JumperObj : MonoBehaviour
{

    public float jumperForce;
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumperForce ,ForceMode2D.Impulse);
        }
       
    }
}
