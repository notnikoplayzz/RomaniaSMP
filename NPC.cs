using System.Numerics;

public class NPC
{
    public Vector3 Position;
    public float Speed = 1.5f;

    public NPC(Vector3 position)
    {
        Position = position;
    }

    public void Update(float deltaTime)
    {
        Position.X += Speed * deltaTime;

        if (Position.X > 20)
            Position.X = -20;
    }
}