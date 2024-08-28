using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;
    public float speed;



    private void Start()
    {
        Debug.Log("M�todo Start");
    }

    private void Update()
    {
        Debug.Log(Time.deltaTime*speed);
        transform.RotateAround(target.position, Vector3.up, speed);
    }
}
