using UnityEngine;
using UnityEngine.UI;

public class VitaTouch : playercollition
{
   

    public Text vite;

    void Update()
    {
        UpdateText(lives);
        //Debug.Log("numero di vite! : " + lives);
    }
    /*
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "SferaVerde" )
        {
            Debug.Log("hai triggerato qualcosa");
            Destroy(coll.collider.gameObject);
            lifesNumber();
        }

    }
*/

    public void UpdateText(int N)
    {   

        vite.text = ("VITE : "+ N.ToString());
    }


}
