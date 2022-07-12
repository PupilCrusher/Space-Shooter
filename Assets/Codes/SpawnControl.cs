using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnControl : MonoBehaviour
{
    public GameObject Asteroid;
    public Vector3 randomPos;
    public int counter = 0;
    public float startTimer ;
    public float spawnTimer ;
    public float resetTimer ;
    public Text text;
    public Text gameOverText;
    public Text gameInfo;
    int score;
    bool gameOverControll = false;
    bool restartGame = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn());
        score = 0;
        text.text = "score = " + score;
        Debug.Log(score);



    }

    private void FixedUpdate()
    {

       
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && restartGame)
        {
            SceneManager.LoadScene("level1s");
        }
    }
    // Update is called once per frame
    IEnumerator spawn()
    {
        yield return new WaitForSeconds(startTimer);
        while(true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(Asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(spawnTimer);

            }
            if (gameOverControll)
            {
                gameInfo.text = "Please Press R for Restart the Game";
                restartGame = true;
                break;
            }
            yield return new WaitForSeconds(resetTimer);
          
        }

     
    
        




    }
    public void scoreCounter(int scoreplus)
    {
        score += scoreplus;
        text.text = "score" + score;
        Debug.Log(score);
    }
    public void gameOver()
    {
        gameOverText.text = "Game Over !";
        gameOverControll = true;
    }
}
