using UnityEngine;

public abstract class BallImprovements
{
    public GameObject Ball { get; }

    protected abstract void Decorate();

    protected BallImprovements(GameObject ball)
    {
        Ball = ball;
    }

    public GameObject GetGameObject()
    {
        return Ball;
    }
}