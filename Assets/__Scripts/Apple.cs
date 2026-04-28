using UnityEngine;

public class Apple : MonoBehaviour
{
    public static float bottomY = -20f; // Y position where Apples are destroyed

    // Update is called once per frame
    void Update()
    {
        if ( transform.position.y < bottomY )
        {
            Destroy( this.gameObject );

            // Get a reference to the ApplePicker component of Main Camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            // Call the AppleDestroyed() method of ApplePicker
            apScript.AppleMissed();
        }
    }
}
