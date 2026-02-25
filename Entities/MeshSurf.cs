using PicoGK;
using System.Numerics;


/*
vectors -> vertex -> edges -> polygon
goal: see is a triangle can be made an 3d object via offset command


*/

namespace Entities
{
    class MeshSurf
    {
        public static void Run()
        {
            Vector3[] aEdges =
            {
                new Vector3(0.0f,0.0f,0.0f),
                new Vector3(10.0f,0.0f,0.0f),
                new Vector3(0.0f,10.0f,0.0f)
            };

            Mesh msh =new();
            msh.AddVertices(aEdges, out int[] anV);
            msh.nAddTriangle(anV[0], anV[1], anV[2]);

            Voxels vTriangle = new Voxels(msh);

            vTriangle.Offset(10.0f);


            Library.oViewer().SetGroupMaterial(0,"FFFF00",5.0f,1.0f);
            Library.oViewer().Add(vTriangle,0);
        }
    }
}