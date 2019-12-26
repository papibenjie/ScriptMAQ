// C# program to illustrate the  
// use of custom attributes 
using ScriptMAQ;
using System;


class Program
{

    // Main Method 
    static void Main(string[] args)
    {
        GameObject obj = new GameObject();

        obj.Components.Add(new Transform());

        Console.WriteLine(obj.ToString());

        GameController controller = new GameController();

        controller.GameLoop();


        Console.ReadLine();
    }
}