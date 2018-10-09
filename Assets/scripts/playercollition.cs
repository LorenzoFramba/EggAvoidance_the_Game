using UnityEngine;


public class playercollition : MonoBehaviour {

    public static int lives = 10;



    void OnCollisionEnter(Collision coll)
    {
        switch (coll.collider.tag)
        {
            case "Obstacle":
                if (lives == 0)
                {
                    FindObjectOfType<gameManager>().EndGame();
                    lives = 1;
                }
                else
                    lives--;
                break;

            case "SferaVerde":
                Destroy(coll.collider.gameObject);
                lifesNumber();
                break;
            case "SferaBlu" :

                break;

        }
    }


    public void lifesNumber(){
        lives++;
    }

    public void stecchito(){
        lives = 1;
        }
    }


