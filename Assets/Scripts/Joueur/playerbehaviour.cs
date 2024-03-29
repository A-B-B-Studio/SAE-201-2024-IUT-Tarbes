
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class playerbehaviour : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 7;
    public Rigidbody2D rb2b;
    public float groundedDistance = 2f;
    public LayerMask groundedMask;

    public int degatCaillou = 20;
    public int currentHealth;
    public int MaxHealth = 300;
    public Animator animator;
    public SpriteRenderer nain;

    public string levelToLoad;

    private Color originalColor;



    bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, groundedDistance, groundedMask);

        if (hit.collider != null)
        {
            return true;

        }
        else
        {
            return false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MaxHealth;
        originalColor = nain.color;

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "boss")
        {
            collision.gameObject.GetComponent<Boss>().currentHealth -= degatCaillou;
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "cailloux")
        {
            currentHealth -= 40;
            StartCoroutine(FlashRed());

        }
        if (collision.gameObject.tag == "Serpent")
        {
            currentHealth -= 40;
            StartCoroutine(FlashRed());
   

        }
    }
    IEnumerator FlashRed()
    {
        // Changer la couleur du sprite en rouge
        nain.color = Color.red;

        // Attendre pendant 1 seconde
        yield return new WaitForSeconds(0.5f);

        // R�tablir la couleur d'origine
        nain.color = originalColor;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
            nain.flipX = false;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
            nain.flipX = true;

  

        }
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb2b.velocity = jumpForce * Vector2.up;
        }

        animator.SetFloat("Speed", speed);

        if (currentHealth <= 0)
        {
            Die();

        }
    }

    

    public void Die()
    {
        Debug.Log("Le Joueur est mort");
        SceneManager.LoadScene(levelToLoad);
    }
    
}
/*using UnityEngine;

public class playerbehaviour : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 7;
    public Rigidbody2D rb2b;
    public float groundedDistance = 2f;
    public LayerMask groundedMask;

    public int degat=20;
    public int currentHealth; 
    public int MaxHealth=300;
    bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, groundedDistance, groundedMask);

        if (hit.collider != null)
        {
            return true;

        }
        else
        {
            return false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
       avancer();
       reculer();
       sauter();
    }

       void avancer(){
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }

    void reculer(){
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
    }

    void sauter(){
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb2b.velocity = jumpForce * Vector2.up;
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Ogre"){
            collision.gameObject.GetComponent<Enemy>().currentHealth -= degat;
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    { 
    if (collision.gameObject.tag == "cailloux") 
    {
        currentHealth -= 20;
    } 
    } 

    void dead(){
        if (currentHealth <= 0){
        }
    }

}
'''*/