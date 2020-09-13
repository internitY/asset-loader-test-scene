using UnityEngine;

public class ResetPositionTo : MonoBehaviour
{
    public Transform targetPos;

    private void OnTriggerEnter(Collider other)
    {
        if(targetPos != null)
            other.transform.position = targetPos.position;
    }
}
