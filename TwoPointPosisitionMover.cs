using UnityEngine;

public class TwoPointPosisitionMover :MonoBehaviour
{
    public Waypoint route;
    public float speed;

    private Vector3 target;

    void start()
    {
        transform.position = route.pointA;
        target = route.pointB;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards
        (
        transform.position, 
        target,
        speed * Time.deltaTime
        );

        if (transform.position == target)
        {
            target = (target == route.pointA) ? route.pointB : route.pointA;
        }
    }
}
