using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform target;
    void LateUpdate()
    {
        if (target == null)
        {
            return;
        } else {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        }
        
    }
}
