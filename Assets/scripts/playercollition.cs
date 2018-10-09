using UnityEngine;


public class playercollition : MonoBehaviour {

    public static int lives = 10;



    void OnCollisionEnter(Collision collisioninfo)
    {

        if (collisioninfo.collider.tag == "Obstacle")
        {
            if (lives == 0)
            {
                FindObjectOfType<gameManager>().EndGame();
                lives = 1;
            }
            else
                lives--;
        }
       
    }


    public void lifesNumber(){
        lives++;
    }

    public void stecchito(){
        lives = 1;
        }
    }


