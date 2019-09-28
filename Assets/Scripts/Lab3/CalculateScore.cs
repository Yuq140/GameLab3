using UnityEngine;

public class CalculateScore : MonoBehaviour {

    public ScoreKeeper sk;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.name.Equals("0")) {
            sk.Score(0);
            collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.77f, 0.77f, 0.77f);
        }

        if (collision.gameObject.name.Equals("5")) {
            sk.Score(5);
            collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.77f, 0.77f, 0.77f);
        }

        if (collision.gameObject.name.Equals("10")) {
            sk.Score(10);
            collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.77f, 0.77f, 0.77f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f);
    }
}
