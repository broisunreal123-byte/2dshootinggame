using UnityEngine;



public class Player : Character
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpPower = 2f;
    [SerializeField] private float speedForce = 2f;
    [SerializeField] private LayerMask GroundLayer;
    [SerializeField] private Transform FeetPos;
    [SerializeField] private float GroundDistance = 0.2f;

    private bool isGrounded;


    void Start()
    {
        hp = 100;
        ApplyFrozen(3f);
    }
    protected override void Update()
    {
        base.Update();
        isGrounded = Physics2D.OverlapCircle(FeetPos.position, GroundDistance, GroundLayer);

        float moveX = Input.GetAxisRaw("Horizontal");
        
        if (isGrounded && Input.GetButtonDown("Jump") && !isFrozen)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
        }
        if (isFrozen)
        {
            rb.linearVelocity = new Vector2(0,rb.linearVelocity.y);
        } else
        {
             rb.linearVelocity = new Vector2(moveX * speedForce, rb.linearVelocity.y);
        }
    }




}
