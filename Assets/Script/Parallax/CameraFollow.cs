using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float followSpeed;
    public Vector2 Offset;
    void Start()
    {
        
    }
    void Update()
    {
        Vector3 targetPos = new Vector3(target.transform.position.x + Offset.x, target.transform.position.y + Offset.y,-10);

      /* Vector3 targetPos = target.transform.position;
        targetPos.x 
        targetPos.z = -10;*/

        transform.position = Vector3.Lerp
            (transform.position, 
            targetPos, 
            followSpeed * Time.deltaTime);
    }
}
