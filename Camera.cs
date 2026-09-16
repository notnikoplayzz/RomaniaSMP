using System.Numerics;

public class Camera
{
    public Vector3 Position;
    public float Distance = 6f;
    public float Height = 3f;

    public void Follow(Vector3 playerPosition)
    {
        Position = new Vector3(
            playerPosition.X,
            playerPosition.Y + Height,
            playerPosition.Z + Distance
        );
    }
}