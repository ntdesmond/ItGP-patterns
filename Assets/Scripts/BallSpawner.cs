using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    
    private void Awake()
    {
        // 1. Create a blue falling ball
        _ = new BlueBall(new FallingBall(
            Instantiate(ballPrefab, new Vector3(-2, 5, 0), Quaternion.identity)
        ));
        
        
        // 2. Create a big falling ball
        _ = new BigBall(new FallingBall(
            Instantiate(ballPrefab, new Vector3(-1, 3, 0), Quaternion.identity)
        ));
        
        
        // 3. Create a red ball
        _ = new RedBall(
            Instantiate(ballPrefab, new Vector3(0, 4, 0), Quaternion.identity)
        );
        
        
        // 4. Create a really big blue falling ball
        _ = new BigBall(new BigBall(new BlueBall(new FallingBall(
            Instantiate(ballPrefab, new Vector3(2, 5, 0), Quaternion.identity)
        ))));
    }
}
