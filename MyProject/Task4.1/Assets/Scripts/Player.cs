using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Player _instance;
    private void Start()
    {
        _instance = this;
    }

    public static Vector3 GetPosition()
    {
        return _instance.transform.position;
    }

    public static void SetPosition(Vector3 _position)
    {
        _instance.transform.position = new Vector3(_position.x, 0.0f, _position.z);
    }

}

