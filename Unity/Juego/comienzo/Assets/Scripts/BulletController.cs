using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody2D myrigidbody2D;
    public float bulletspeed = 10f;
    public GameManager myGameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        myGameManager = FindFirstObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        myrigidbody2D.linearVelocity = new Vector2(bulletspeed, myrigidbody2D.linearVelocity.y);
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("ItemGood")){
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("ItemBad")){
            myGameManager.AddScore();
            Destroy(collision.gameObject);
        }
    }
}
