using UnityEngine;

public class Basket : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;

        // Set the Z position for correct 3D conversion
        mousePos2D.z = -Camera.main.transform.position.z;

        // Convert the point to 3D game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint( mousePos2D );

        // Move the basket's x position to the mouse's x position
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if ( collidedWith.CompareTag("Apple") ) {
            Destroy( collidedWith );        
        }
    }
}