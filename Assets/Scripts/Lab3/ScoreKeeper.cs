using UnityEngine;

public class ScoreKeeper : MonoBehaviour {
    public GameObject textBox;

    public int Scored { get; set; }

    public void Score(int i) {
        Scored += i;
        textBox.GetComponent<UnityEngine.UI.Text>().text = "Score: " + Scored;
    }
}
