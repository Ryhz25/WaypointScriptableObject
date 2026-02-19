using UnityEngine;

[CreateAssetMenu(fileName = "Waypoint", menuName = "Scriptable Object/waypoint")]
public class Waypoint : ScriptableObject
{
    public Vector3 pointA;
    public Vector3 pointB;
}