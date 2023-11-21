using UnityEngine;

public class ReduceMovementOnGround : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            // �浹�� ������Ʈ�� ground �±��� ���, x�� �ӵ��� 70% ���ҽ�ŵ�ϴ�.
            Vector2 velocity = rb.velocity;
            velocity.x *= 0.3f;
            rb.velocity = velocity;
        }
    }
}