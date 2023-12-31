using Unity.VisualScripting;

using UnityEngine;

public class PatrolPoint : MonoBehaviour {

    [SerializeField] private bool isInPatrolNet = true;

    public void SetPatrolNetStatus(bool status) {
        isInPatrolNet = status;
    }
    public bool GetPatrolNetStatus() {
        return isInPatrolNet;
    }

    public void SetName(string name) {
        gameObject.name = name;
    }
    public string GetName() {
        return gameObject.name;
    }
    

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, .3f);
        Gizmos.DrawLine(transform.position, new (transform.position.x,-1,transform.position.z));
        Gizmos.DrawLine(transform.position, new (transform.position.x,100,transform.position.z));

    }
}