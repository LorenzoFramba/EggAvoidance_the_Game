using UnityEngine;
using UnityEngine.UI;

public class VitaTouch : playercollition
{
   

    public Text vite;


    void Update()
    {
        UpdateText(lives);
        //Debug.Log("numero di vite: " + lives);
    }

    void onTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Life")
        {
            Debug.Log("hai triggerato qualcosa");
            Destroy(gameObject);
            FindObjectOfType<playercollition>().lifesNumber();
           // playercollition.lifesNumber();
        }

    }
    public void UpdateText(int N)
    {   

        vite.text = ("VITE : "+ N.ToString());
    }


}
