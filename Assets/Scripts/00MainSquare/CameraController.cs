using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Transform target;

    [SerializeField] private float minX = -9f;
    [SerializeField] private float maxX = 9f;
    [SerializeField] private float minY = -8f;
    [SerializeField] private float maxY = 8f;


    private float originalZ = -10f;


    void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, originalZ);

        Vector3 tempPosition = new Vector3(target.position.x, target.position.y, originalZ);

        tempPosition.x = Mathf.Clamp(tempPosition.x, minX, maxX);
        tempPosition.y = Mathf.Clamp(tempPosition.y, minY, maxY);

        transform.position = tempPosition;
    }
}
