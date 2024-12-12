using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float playerJumpForce = 20f;
    public float playerSpeed = 5f;
    public Sprite[] mySprites; // Sprites para animar el movimiento
    private int index = 0;
    private int direction = 1; // 1 para derecha, -1 para izquierda

    private Rigidbody2D myrigidbody2D;
    private SpriteRenderer mySpriteRenderer;
    public GameObject Bullet;
    public GameManager myGameManager;

    void Start()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(WalkCoRutine());
        myGameManager = FindFirstObjectByType<GameManager>();
    }

    void Update()
    {
        Vector2 velocity = myrigidbody2D.linearVelocity;

        // Movimiento hacia la derecha
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = playerSpeed;
            direction = 1;
        }
        // Movimiento hacia la izquierda
        else if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -playerSpeed;
            direction = -1;
        }
        // Sin movimiento horizontal
        else
        {
            velocity.x = 0;
        }

        // Aplicar el movimiento al Rigidbody
        myrigidbody2D.linearVelocity = velocity;

        // Girar el sprite dependiendo de la dirección
        mySpriteRenderer.flipX = direction == -1;

        // Salto
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myrigidbody2D.linearVelocity = new Vector2(myrigidbody2D.linearVelocity.x, playerJumpForce);
        }

        // Disparar proyectil
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ItemGood"))
        {
            Destroy(collision.gameObject);
            myGameManager.AddScore();
        }
        else if (collision.CompareTag("ItemBad"))
        {
            Destroy(collision.gameObject);
            PlayerDeath();
        }
        else if (collision.CompareTag("DeathZone"))
        {
            PlayerDeath();
        }
    }

    void PlayerDeath()
    {
        SceneManager.LoadScene("SampleScene");
    }

    IEnumerator WalkCoRutine()
    {
        while (true)
        {
            // Cambiar el sprite solo si el jugador se está moviendo
            if (myrigidbody2D.linearVelocity.x != 0)
            {
                mySpriteRenderer.sprite = mySprites[index];
                index++;
                if (index >= mySprites.Length)
                {
                    index = 0;
                }
            }

            yield return new WaitForSeconds(0.1f); // Intervalo entre cambios de sprite
        }
    }
}
