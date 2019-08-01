
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovment pm;
   
    void OnCollisionEnter(Collision collisionInfo) {
        // Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Obstacle") {
            pm.enabled = false;
            FindObjectOfType<Gm>().gameOver();
        }
    }
}
