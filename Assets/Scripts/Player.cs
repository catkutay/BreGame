using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
   [SerializeField] private DialogueUI dialogueUI;

   public DialogueUI DialogueUI => dialogueUI;

   public IInteractable interactable {get; set;}

    public float moveSpeed = 1f;

    public float collisionOffset = 0.05f;

    public ContactFilter2D movementFilter;

    public GameObject[] players;


    // public maceattack Maceattack;

    // public MaceAttack maceAttack;

    Vector2 movementInput;

    SpriteRenderer spriteRenderer;

    Rigidbody2D rb;

    Animator animator;

    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    private static bool playerExists;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        
        
    }

    private void FixedUpdate()
        //If movement input is not equal to 0, try to move
    {

        if(movementInput != Vector2.zero)
        {
            int count = rb.Cast(
                movementInput, //X and Y values between -1 and 1 that represent the direction from teh body to look for collisions
                movementFilter, //Settings that determine where a collision can occur
                castCollisions, //List of collisions to store teh found collisions into after the Cast is finished
                moveSpeed * Time.fixedDeltaTime +collisionOffset); //Ammount of cast equal to the movement plus an offset
            if(count == 0){
                rb.MovePosition(rb.position + movementInput * moveSpeed * Time.fixedDeltaTime);

            }
            
            animator.SetBool("IsMoving", true);

        } else{
            animator.SetBool("IsMoving", false);
        }
        
        if(movementInput.x < 0){
            spriteRenderer.flipX = true;
        } else if (movementInput.x > 0){
            spriteRenderer.flipX = false;
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (interactable != null)
            {
                interactable.Interact(this);
            }
            else
            {
                interactable = null;
            }
        }

    }

    // public void update()
    // {
    //     Debug.Log("Working");
    //     if (interactable != null)
    //     {
    //         interactable.Interact(this);
    //     }
    // }

   void FindStartPos()
   {
    transform.position = GameObject.FindWithTag("StartPos").transform.position;
   }

    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.tag == "Enemy")
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
            
        }
    }

    

}
