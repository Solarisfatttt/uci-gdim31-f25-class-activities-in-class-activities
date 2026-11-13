using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform target;
    private bool _isChasing = false;

    private void Update()
    {
        if (_isChasing)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
    public void chaseCat()
    {
        _isChasing = true;
    }
    public void stopChaseCat()
    {
        _isChasing=false;
    }
    
}
