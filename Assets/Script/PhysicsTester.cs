using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

using System.Linq;

public class PhysicsTester : MonoBehaviour
{
    private Rigidbody2D rb;
    public LayerMask layer;
    public float raidus;
    public float force;


    Dictionary<string, AudioClip> MusicDatabase = new();


    Dictionary<string, int> wordDatabase = new();

    string[] allWodrs;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up,20, layer);

        if(hit.collider != null)
        {
            Debug.Log("Hit: " + hit.collider.name);
        }
    }
    private void Update()
    {
        if (Keyboard.current.spaceKey.wasReleasedThisFrame)
        {
            print("press space");
            DomainExpansion();
        }
    }
    public void DomainExpansion()
    {
        Collider2D[] collisions =  Physics2D.OverlapCircleAll(transform.position, raidus);
        
        foreach(Collider2D collision in collisions)
        {
            Debug.Log("coll " + collision.name);

            if(collision.gameObject.GetComponent<Rigidbody2D>() != null)
            {
                Vector2 dir = (collision.transform.position - transform.position).normalized;

                collision.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;

                collision.GetComponent<Rigidbody2D>().AddForce(dir * force, ForceMode2D.Impulse);
            }
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, Vector2.up * 20);
        Gizmos.color = Color.purple;
        Gizmos.DrawWireSphere(transform.position, raidus);
    }
}
