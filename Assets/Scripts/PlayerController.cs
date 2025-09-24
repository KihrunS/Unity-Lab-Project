using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    [SerializeField] float sprintMultiplier;

    [SerializeField] Rigidbody2D Rigidbody2D;

    [SerializeField] GameObject myCircle;
    [SerializeField] GameObject worldCircle;
    [SerializeField] GameObject myEnemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void SpawnThing(GameObject thing)
    {
        Instantiate(thing, transform.position, Quaternion.identity);
    }

    void DestroyThing(GameObject thing)
    {
        Destroy(thing);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            DestroyThing(worldCircle);  
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            SpawnThing(myCircle);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        float x = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Vector2 movement = new Vector2(x * sprintMultiplier, 0) * speed * Time.deltaTime;
            transform.Translate(movement);
        } else
        {
            Vector2 movement = new Vector2(x, 0) * speed * Time.deltaTime;
            transform.Translate(movement);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            SpawnThing(myEnemy);
        }
    }
}
