using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   
    public GameObject obstacle;
    public Transform spawnPoint;
    int score = 0;
    public TextMesh scoreText;
    public GameObject playButton;
    public GameObject Text;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
    IEnumerator SpawnObstacles(){
        while(true){
            float waitTime = Random.Range(0.5f,2f);

            yield return new WaitForSeconds(waitTime);

            Instantiate(obstacle,spawnPoint.position,Quaternion.identity);

        }
    }

    void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void GameStart()
    {
      player.SetActive(true);
      playButton.SetActive(false);
      Text.SetActive(false);
     StartCoroutine("SpawnObstacles");
     InvokeRepeating("ScoreUp",2f,1f);
    }
}
