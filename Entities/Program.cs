using PicoGK;
using Entities;


try
{
    Library.Go(0.5f, Entities.MeshSurf.Run);
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}