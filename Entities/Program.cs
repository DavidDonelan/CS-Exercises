//using Leap71.ShapeKernel; //if available
using PicoGK;
using Entities;


//string strOutputFolder = ""; //use whatever folder

try
{
    PicoGK.Library.Go(
        0.5f,
        Entities.MeshSurf.Run,
        strOutputFolder
        );
}
catch (Exception e)
{
    Console.WriteLine("Failed to run Task.");
    Console.WriteLine(e.ToString());
}
