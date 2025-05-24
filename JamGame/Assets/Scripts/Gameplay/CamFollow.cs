using UnityEngine;
public class CamFollow : MonoBehaviour
{
    public Transform Me;
    float f_posX;
    Vector3 v3_newPos;

    private void Update()
    {
        f_posX = Me.position.x;
        v3_newPos.x = f_posX;
        v3_newPos.z = transform.position.z;
        transform.position = v3_newPos;
    }
}