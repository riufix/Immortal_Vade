
using UnityEngine;

public class PointInTime
{
    public Vector3 position;
    public Quaternion rotation;
    public float Life;

    public PointInTime (Vector3 _position, Quaternion _rotation, float _life)
    {
        position = _position;
        rotation = _rotation;
        Life = _life;
    }


}
