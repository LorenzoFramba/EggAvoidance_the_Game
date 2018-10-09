using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour {
    
    public void EndGame(){

        FindObjectOfType<BlockRemover>().IncrementScore(0);
        FindObjectOfType<Score>().UpdateText(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }

}
