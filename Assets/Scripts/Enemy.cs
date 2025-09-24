using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Enemy : MonoBehaviour
{

    [SerializeField] int direction = 1;
    [SerializeField] float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(1 * direction, 0) * speed * Time.deltaTime;
        transform.Translate(movement);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        direction *= -1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        direction *= -1;
    }
}
