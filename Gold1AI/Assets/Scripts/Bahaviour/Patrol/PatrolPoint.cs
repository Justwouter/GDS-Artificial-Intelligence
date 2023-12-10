using Unity.VisualScripting;

using UnityEngine;

public class PatrolPoint : MonoBehaviour {

    [SerializeField] private bool isInPatrolNet = true;

    public bool GetPatrolNetStatus() {
        return isInPatrolNet;
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, .3f);
    }
}