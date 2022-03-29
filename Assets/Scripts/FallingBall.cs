using UnityEngine;

public class FallingBall : BallImprovements
{
    public FallingBall(GameObject ball) : base(ball)
    {
        Decorate();
    }
    
    public FallingBall(BallImprovements decorator) : base(decorator.Ball)
    {
        Decorate();
    }

    protected sealed override void Decorate()
    {
        var body = Ball.GetComponent<Rigidbody>();
        if (body == null)
        {
            body = Ball.AddComponent<Rigidbody>();
        }

        body.useGravity = true;
        body.isKinematic = false;
    }
}