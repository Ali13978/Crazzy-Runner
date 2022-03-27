using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bool Abc = true;
    bool Cdf = true;

    Rigidbody2D MyRigidBody;
    Vector2 PathVelocity;

    [SerializeField] float PathSpeedInStart = 2f;
    [SerializeField] float PathSpeedAfter1Sec = 0.1f;
    [SerializeField] int MaxSpeed = 30;
     // Start is called before the first frame update
    void Start()
    {
        PathVelocity = new Vector2(0f , 0f);
        MyRigidBody = GetComponent<Rigidbody2D>();
    }

    private void Move()
    {
        MyRigidBody.velocity = PathVelocity;
    }

    private void SetMaxSpeed()
    {
        if(PathVelocity.x <= 0 - MaxSpeed)
        {
            PathVelocity.x = 0 - MaxSpeed;
        }
    }

    private void MoveHorizontally()
    {
        if(Cdf)
        {
            PathVelocity.x -= PathSpeedInStart;
            Cdf = false;
        }

        if (Abc)
        {
            Abc = false;
            StartCoroutine(ABC());
        }
    }

    private IEnumerator ABC()
    {
        yield return new WaitForSeconds(1f);
        PathVelocity.x -= PathSpeedAfter1Sec;
        Abc = true;
    }

    void Update()
    {
        MoveHorizontally();
        Move();
        SetMaxSpeed();
    }
}
