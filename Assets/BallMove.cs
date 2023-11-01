using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField] float forceOffset;
    [SerializeField] float speed;
    Rigidbody2D body;

    private void Start()
    {
        MyStart(Vector3.right);
    }
    public void MyStart(Vector3 vec)
    {
        body = GetComponent<Rigidbody2D>();
        body.AddForce(vec * speed);
    }
    public void Stop()
    {
        body.velocity = Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            float force = (transform.position.y - collision.collider.transform.position.y) * forceOffset;
            body.AddForce(new Vector3(0f, force, 0f));
        }
    }


}
