using UnityEngine;


public class Fox : MonoBehaviour
{
    public object JumpButton;
    public float jump;
    private Rigidbody2D rb;
    private bool isGrounded;
    public GameObject pauseButton;
    public GameObject winPanel;
    public GameObject jumpButton;
    public GameObject attackButton;
    public static bool GameIsPaused = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }
    public void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jump);
        }
    }

    void Update()
    {
    
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Home"))
        {
            Time.timeScale = 0f;
            GameIsPaused = true;
            pauseButton.SetActive(false);
            winPanel.SetActive(true);
            jumpButton.SetActive(false);
            attackButton.SetActive(false);
        }
    }
}
