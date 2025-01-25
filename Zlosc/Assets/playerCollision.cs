using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public
        //public GameManager GM;
        void OnCollisionEnter(UnityEngine.Collision other)
    {

        //Debug.Log(collisionInfo.collider.name);
        if (other.transform.GetComponent<Collider>().name != "base") return;
        
        Debug.Log(FindFirstObjectByType<Score>().score);
        //FindObjectOfType<SCOREBOARD>().UpdateScoreboard();
        FindFirstObjectByType<GameManager>().EndGame();
    }
}
