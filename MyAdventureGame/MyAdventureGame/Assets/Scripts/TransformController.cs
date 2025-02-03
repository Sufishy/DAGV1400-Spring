using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        // Move the target Diagonally by adding y
        var x = Mathf.PingPong(Time.time, 2);
       var y = Mathf.PingPong(Time.time, 2);
        
        // this - y makes the characters move middle to left
        var p = new Vector3(-y, x, 1);
        transform.position = p;
        
        // Rotate the target GameObject
        transform.Rotate(new Vector3(0, 0, 0) * Time.deltaTime);
    }
}
