using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f;

    // Update is called once per frame
    void Update()
    {
        if (transform.positon.y < bottomY) {
            Destroy(this.gameObject);
        }
    }
}
