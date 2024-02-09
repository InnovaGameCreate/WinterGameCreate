using UnityEngine;

public class RockMove : MonoBehaviour
{
    public float pushForce = 2.0f;
    public float maxDistance = 3.0f;
    public double GravityDistance = 0.1; 
    private Vector3 originalPosition;
    private Rigidbody rb;
    public bool PlayerTouch = false;
    public float additionalGravity = 10f; // 追加の重力の強さ

    private void Start()
    {
        originalPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Vector3.Distance(originalPosition, transform.position) >= maxDistance)
        {
            // 移動中かつ一定の距離移動したら物理演算を停止
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
       if (Mathf.Abs(transform.position.y - originalPosition.y ) >= GravityDistance && !PlayerTouch)
            rb.AddForce(Vector3.down * additionalGravity, ForceMode.Acceleration);
        PlayerTouch = false;

    }


    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerTouch = true;
        }
    }

}
