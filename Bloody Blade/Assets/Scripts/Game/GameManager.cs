using UnityEngine;

public class GameManager : MonoBehaviour
{
    PlayerStats player;
    GameObject[] enemies;
    public bool gameOver = false;
    public string gameState;
    
    void Awake(){
        player = GameObject.Find("Player").GetComponent<PlayerStats>();
    }
    void Update(){
        enemies = GameObject.FindGameObjectsWithTag("enemy");

        if(player.health <= 0){
            gameOver = true;
            gameState = "Lose";
        }

        if(gameOver){
            for(int i = 0; i < enemies.Length; i++){
                Destroy(enemies[i].gameObject);
            }
        }

        if(gameState == "Lose"){
            Debug.Log("You Lost");
        }
        else if(gameState == "Win"){
            Debug.Log("You Win");
        }
    }
}
