
using UnityEngine;

public class player_collision : MonoBehaviour {
    // Start is called before the first frame update
    public player_movement movement;
    // Update is called once per frame

    private void OnCollisionEnter(Collision collisioninfo) {

        if(collisioninfo.collider.tag == "obstacle") {
            movement.enabled = false;
            FindObjectOfType<game_manager>().endgame();
        }
    }
}
