﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WaypointController : MonoBehaviour
{   /// add AI's movement speed and their target waypoints
    public List<Transform> Waypoints = new List<Transform>();
    private Transform TargetWaypoint;
    private int TargetWaypointIndex = 0;
    private float MinDistance = 1.0f;
    private float LastWaypointIndex;
    private float MovementSpeed = 90.0f;
    // Start is called before the first frame update
    void Start()
    {
        TargetWaypoint = Waypoints[TargetWaypointIndex];
    }
    // Update is called once per frame
    void Update()
    {
        float MovementStep = MovementSpeed * Time.deltaTime;
        float distance = Vector3.Distance(transform.position, TargetWaypoint.position);
        CheckDistanceToWaypoint(distance);
        transform.position = Vector3.MoveTowards(transform.position, TargetWaypoint.position, MovementStep);
    }
    void CheckDistanceToWaypoint(float currentDistance)
    {
        if(currentDistance <= MinDistance)
        {
            TargetWaypointIndex++;
            UpdateTargetWaypoint();
        }
    }
    void UpdateTargetWaypoint()
    {
        TargetWaypoint = Waypoints[TargetWaypointIndex];
    }
}