using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    [SerializeField] GameObject myPickup;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string objectName = collision.gameObject.name;
        Debug.Log(objectName);

        if (collision.gameObject.CompareTag("Player"))
        {
            SpawnPickup(myPickup);
        }
    }

    void SpawnPickup(GameObject pickup)
    {
        Instantiate(pickup, transform.position, Quaternion.identity);
    }
}
