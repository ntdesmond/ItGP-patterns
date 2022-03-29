using UnityEngine;

public class BlueBall : BallImprovements
{
    public BlueBall(GameObject ball) : base(ball)
    {
        Decorate();
    }
    
    public BlueBall(BallImprovements decorator) : base(decorator.Ball)
    {
        Decorate();
    }

    protected sealed override void Decorate()
    {
        Ball.GetComponent<Renderer>().material.color = Color.blue;
    }
}