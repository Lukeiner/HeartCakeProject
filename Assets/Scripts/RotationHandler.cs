using UnityEngine;

public class RotationHandler : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 200f;

    private float previousMouseX;
    private bool isDragging = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            previousMouseX = Input.mousePosition.x;
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging)
        {
            float deltaX = Input.mousePosition.x - previousMouseX;
            float rotationAmount = deltaX * rotationSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up, -rotationAmount);

            previousMouseX = Input.mousePosition.x;
        }
    }
}
