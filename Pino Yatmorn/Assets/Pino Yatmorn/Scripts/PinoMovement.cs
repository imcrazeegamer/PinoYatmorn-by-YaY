using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PinoMovement : MonoBehaviour {
    public float MovementSpeed;
    private Animator anim;
    private Rigidbody2D rigidbody;
    private bool playerMoving;
    private Vector2 lastMove;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        playerMoving = false;
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * MovementSpeed * Time.deltaTime, 0f, 0f));
           // rigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * MovementSpeed, rigidbody.velocity.y);
            playerMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * MovementSpeed * Time.deltaTime, 0f));
            //rigidbody.velocity = new Vector2(rigidbody.velocity.x, Input.GetAxisRaw("Vertical") * MovementSpeed);
            playerMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);
    }

    /*
    public void MoveUp()
    {
        player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpHight * Time.deltaTime);
        player.GetComponent<Animator>().SetInteger("State", 0);
    }
    public void MoveDown()
    {

    }
    public void MoveLeft(Button btn)
    {
        player.transform.Translate(Vector2.left * MovementSpeed * Time.deltaTime);
        player.GetComponent<Animator>().SetInteger("State", 1);
    }
    public void MoveRight(Button btn)
    {
        do
        {
            player.GetComponent<Animator>().SetInteger("State", 1);
            player.transform.Translate(Vector2.right * MovementSpeed * Time.deltaTime);
        } while (Input.GetTouch(0).phase == TouchPhase.Stationary);
    }
    */
}
