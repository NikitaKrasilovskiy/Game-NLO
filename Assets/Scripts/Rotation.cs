
using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Transform Point;
    [SerializeField] private int x, y;
    void Start()
    {
        Cursor.visible = true;
        Time.timeScale = 1f;
    }
    void Update()
    {
        transform.RotateAround(Point.transform.position, new Vector3(x, y, 10), 10 * Time.deltaTime);
        transform.Rotate(new Vector3(10, 35, 10) * Time.deltaTime);
    }
}