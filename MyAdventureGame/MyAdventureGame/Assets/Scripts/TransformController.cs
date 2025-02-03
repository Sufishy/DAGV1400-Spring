using UnityEngine;

public class TransformController : MonoBehaviour
{
   // public float startX = -2f; // Starting X position
    // tried to make pinpong start further left than 0, but was unsuccesfful
    // public float range = 2f; // The range of the PingPong movement
    private void Update()
    {
        // Move the target Diagonally by adding y
        var x = Mathf.PingPong(Time.time, 2);
            
        var p = new Vector3(x, 1, -3);
        
        // I just like the snail closer, I think it's funny
        
        transform.position = p;
        
        // Rotate the target GameObject
        transform.Rotate(new Vector3(0, 200, 0) * Time.deltaTime);
    }
}
