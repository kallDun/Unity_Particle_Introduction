using UnityEngine;

public class CameraFlyingScript : MonoBehaviour
{
    public Vector3 StartPosition, EndPosition;
    public float animation_time;

    float time;
    void Update()
    {
        time += Time.deltaTime;
        gameObject.transform.position = Vector3.Lerp(StartPosition, EndPosition, time / animation_time);
    }
}