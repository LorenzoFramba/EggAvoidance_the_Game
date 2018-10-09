using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class BlockRemover : MonoBehaviour
{
    public static float points = 0f;

    public void IncrementScore(float tmp)
    {
        if (tmp > 0f)
            points += tmp;
        else
            points = 0;
        Debug.Log(points);

    }


    public bool near()
    {
        bool vic = false;
        float l = playermovement.position.x;

            if (transform.position.x > l){
                if((transform.position.x - l) <= 1){
                    vic=true;
                    Debug.Log("SONO VICINO");
                }
            if (transform.position.x<l){
                if (l - transform.position.x  <= 1){
                    Debug.Log("SONO VICINO");
                    vic=true;
                    }
                }
        }
        return vic;
    }


    void Update()
    {
        //  near();
      //  Debug.Log("X! " + playermovement.position.x);
     //   Debug.Log("X! " + transform.position.x);
        if (transform.position.z < -40)
        {
            Destroy(gameObject);
            IncrementScore(0.20f);
        }

    }


}