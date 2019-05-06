using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public enum Type { Moves_X, Moves_Y, Move_Circle };
    public Type myType;
    [Range(-5f, 5f)]
    public int range;

    Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }
    void Update ()
    {
        if(myType == Type.Moves_X)
            transform.position = new Vector3(initialPosition.x + Mathf.Sin(Time.fixedTime) * range, transform.position.y, transform.position.z);

        if (myType == Type.Moves_Y)
            transform.position = new Vector3(transform.position.x, initialPosition.y + Mathf.Sin(Time.fixedTime) * range, transform.position.z);

        if(myType == Type.Move_Circle)
            transform.position = new Vector3(initialPosition.x + Mathf.Cos(Time.fixedTime) * range, initialPosition.y + Mathf.Sin(Time.fixedTime) * range, transform.position.z);
    }
}
