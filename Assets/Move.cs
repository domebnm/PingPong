using System;
using UnityEngine;
public class Move : MonoBehaviour
{
    public float speed;
    float posY = 0;
    [Serializable] struct Offset { public float up; public float down; };
    [SerializeField] Offset offset;

    private void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * speed;
        posY += mouseY;
        posY = Mathf.Clamp(posY, offset.down, offset.up);
        transform.position = new Vector3(transform.position.x, posY);
    }
}
