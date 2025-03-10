using System.Collections;
using UnityEngine;

public class BouncyShrink : MonoBehaviour
{
    public float bounceForce = 3f;

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        StartCoroutine(Shrink());
    }

    private IEnumerator Shrink()
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        yield return null;
    }
}