using UnityEngine;

public class AppleTreeMovement : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float changeDirChance = 0.2f;
    public float appleDropDelay = 1f;

    void Start()
    {
        // Start dropping apples
        Invoke("DropApple", 2f);
    }

    void DropApple() {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // Changing Direction
        if (pos.x < -leftAndRightEdge) {
            speed = Mathf.Abs(speed); // Go right
        } else if (pos.x > leftAndRightEdge){
            speed = -Mathf.Abs(speed); // Go left
        }
    }

    void FixedUpdate() {
        //Random direction changes
        if (Random.value < changeDirChance){
            speed *= -1; // Change direction
        }
    }
}
