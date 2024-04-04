using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following : MonoBehaviour
{
    public GameObject leader; // Selected game object to follow - assign in inspector
    public int steps; // Number of steps to stay behind - assign in inspector

    private Queue<Vector3> record = new Queue<Vector3>();
    private Vector3 lastRecord;

    void FixedUpdate()
    {
        // Record position of leader
        record.Enqueue(leader.transform.position);

        // Remove last position from the record and use it for our own
        if (record.Count > steps)
        {
            this.transform.position = record.Dequeue();
        }
    }
}
