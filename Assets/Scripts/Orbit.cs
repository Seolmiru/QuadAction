using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;


// ������ ���� ����
public class Orbit : MonoBehaviour
{
    public Transform target;
    public float orbitSpeed;
    Vector3 offSet;

    void Start()
    {
        
    }

    void Update()
    {
        transform.RotateAround(target.position,
                               Vector3.up,
                               orbitSpeed * Time.deltaTime);
    }
}
