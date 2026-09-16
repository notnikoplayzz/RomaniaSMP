using System.Numerics;

public class Player
{
    public Vector3 Position = new Vector3(0, 1, 0);
    public float Speed = 5f;

    public void Update(float deltaTime)
    {
        Vector3 movement = Vector3.Zero;

        if (Input.IsKeyDown("W"))
            movement.Z -= 1;

        if (Input.IsKeyDown("S"))
            movement.Z += 1;

        if (Input.IsKeyDown("A"))
            movement.X -= 1;

        if (Input.IsKeyDown("D"))
            movement.X += 1;

        if (movement != Vector3.Zero)
        {
            movement = Vector3.Normalize(movement);
            Position += movement * Speed * deltaTime;
        }
    }
}