using UnityEngine;
using UnityEngine.UI;

public class Score : BlockRemover {

    public int score;
    public Text scor;

    public void UpdateText(int score)
    {
        scor.text = score.ToString();
    }

   void  Update () {
        score = (int)points;
        UpdateText(score);
    }
}
