using UnityEngine;

public class BigBall : BallImprovements
{
    public BigBall(GameObject ball) : base(ball)
    {
        Decorate();
    }
    
    public BigBall(BallImprovements decorator) : base(decorator.Ball)
    {
        Decorate();
    }

    protected sealed override void Decorate()
    {
        Ball.transform.localScale *= 1.5f;
    }
}