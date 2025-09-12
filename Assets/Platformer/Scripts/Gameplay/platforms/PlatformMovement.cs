using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private Transform[] movementPoints;
    [SerializeField] private float movementVelocity;
    private int nextPlatform = 1;
    private bool orderPlatforms= true;

    private void Update()
    {
        if(orderPlatforms && nextPlatform >= movementPoints.Length -1)
        {
            orderPlatforms = false;
        }
        else if(!orderPlatforms && nextPlatform <= 0)
        {
            orderPlatforms = true;
        }

        if (Vector2.Distance(transform.position, movementPoints[nextPlatform].position) <0.1f)
        {
            if(orderPlatforms)
            {
                nextPlatform += 1;
            }
            else
            {
                nextPlatform -= 1;
            }
        }
        transform.position= Vector2.MoveTowards(transform.position, movementPoints[nextPlatform].position, movementVelocity * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(this.transform);
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null);
        }
    }
}
