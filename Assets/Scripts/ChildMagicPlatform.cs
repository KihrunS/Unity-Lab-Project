using UnityEngine;

public class ChildMagicPlatform : MagicPlatform
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        location = new Vector3(0, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Move()
    {
        base.Move();
        transform.position += new Vector3(5, 0, 0);
    }
}