using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D Rigidbody_Player;
    [SerializeField] float F_MoveSpeed;
    [SerializeField] Animator Animator_Player;

    void Update()
    {
        if (!Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.LeftArrow))
        {
            //Animator_Player.SetBool("Walk_Left", false);
            Rigidbody_Player.velocity = Vector2.zero;
            Rigidbody_Player.angularVelocity = 0;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 v2_newSpeedLeft = new(-F_MoveSpeed, Rigidbody_Player.velocity.y);
            Rigidbody_Player.velocity = v2_newSpeedLeft;
            //Animator_Player.SetBool("Walk_Left", true);
        }


        if (!Input.GetKey(KeyCode.D) || !Input.GetKey(KeyCode.RightArrow))
        {
            //Animator_Player.SetBool("Walk_Right", false);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 v2_newSpeedRight = new(F_MoveSpeed, Rigidbody_Player.velocity.y);
            Rigidbody_Player.velocity = v2_newSpeedRight;
            //Animator_Player.SetBool("Walk_Right", true);
        }
    }
}