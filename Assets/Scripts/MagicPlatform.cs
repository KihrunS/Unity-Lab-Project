using UnityEngine;


public class MagicPlatform : MonoBehaviour
{
    [SerializeField] protected Vector3 location;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Move();
        }
    }

    protected virtual void Move()
    {
        transform.position += location;
    }
}
