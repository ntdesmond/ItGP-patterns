using UnityEngine;

public class RedBall : BallImprovements
{
    public RedBall(GameObject ball) : base(ball)
    {
        Decorate();
    }
    
    public RedBall(BallImprovements decorator) : base(decorator.Ball)
    {
        Decorate();
    }

    protected sealed override void Decorate()
    {
        Ball.GetComponent<Renderer>().material.color = Color.red;
    }
}