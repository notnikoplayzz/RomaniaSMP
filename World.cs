using System;
using System.Collections.Generic;
using System.Numerics;

public class World
{
    public Player Player;
    public Camera Camera;
    public List<NPC> NPCs;

    public World()
    {
        Player = new Player();
        Camera = new Camera();

        NPCs = new List<NPC>();

        for (int i = 0; i < 10; i++)
        {
            NPCs.Add(
                new NPC(new Vector3(i * 3, 0, 5))
            );
        }
    }

    public void Update(float deltaTime)
    {
        Player.Update(deltaTime);

        Camera.Follow(Player.Position);

        foreach (NPC npc in NPCs)
        {
            npc.Update(deltaTime);
        }
    }
}