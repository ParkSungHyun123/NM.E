using UnityEngine;

public class FloatingAstronaut : MonoBehaviour
{
    public float floatSpeed = 1.0f; // �յ� ���ٴϴ� �ӵ� ����
    public float floatRange = 1.0f; // �յ� ���ٴϴ� ���� ����

    private Rigidbody2D rb;
    private Vector2 initialPosition;
    private float randomOffset;

    void Start()
    {
        // Rigidbody2D ������Ʈ ��������
        rb = GetComponent<Rigidbody2D>();

        // �ʱ� ��ġ ����
        initialPosition = rb.position;

        // �ʱ� ��ġ���� �������� ����(offset) ����
        randomOffset = Random.Range(0f, 2f * Mathf.PI);
    }

    void Update()
    {
        // �������� ���Ʒ��� �յ� ���ٴϰ� �ϱ�
        float yOffset = Mathf.Sin(Time.time * floatSpeed + randomOffset) * floatRange;
        Vector2 newPosition = initialPosition + new Vector2(0f, yOffset);

        // Rigidbody2D�� ����Ͽ� ��ġ ����
        rb.MovePosition(newPosition);
    }
}
