using UnityEngine;

public class DestroyObject : MonoBehaviour {
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            gameObject.SetActive(false);
        }
    }
}
