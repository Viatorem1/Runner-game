using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float lifeTime;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        rb.velocity = Vector2.left * speed;
    }
}
