
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 500f;
    public float sidewaysforce = 500f;
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y< -1f) {
            FindObjectOfType<game_manager>().endgame();
        }
    }
}
