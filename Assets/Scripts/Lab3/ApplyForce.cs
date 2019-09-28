using UnityEngine;

public class ApplyForce : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed = 10f;

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            rb.AddForce(transform.right * speed * Time.deltaTime, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            rb.AddForce(-transform.right * speed * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
}
