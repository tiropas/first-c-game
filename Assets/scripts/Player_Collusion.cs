using UnityEngine;

public class Player_Collusion : MonoBehaviour {

    public player_movment moving;



    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "problem")
        {
            moving.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
