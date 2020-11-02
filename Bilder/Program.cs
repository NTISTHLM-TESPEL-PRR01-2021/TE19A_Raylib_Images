using System;
using Raylib_cs;
using System.Numerics;

namespace Bilder
{
  class Program
  {
    static void Main(string[] args)
    {

      Raylib.InitWindow(800, 600, "Bildtest");

      Texture2D duckImage = Raylib.LoadTexture("duck.png");

      float x = 20;

      while (!Raylib.WindowShouldClose())
      {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
          x += 0.1f;
        }


        Raylib.BeginDrawing();

        Raylib.ClearBackground(Color.BEIGE);

        //Raylib.DrawTexture(duckImage, 20, 20, Color.WHITE);

        Raylib.DrawTextureEx(duckImage, new Vector2(x, 20), 0f, 0.25f, Color.WHITE);

        Raylib.EndDrawing();
      }


    }
  }
}
