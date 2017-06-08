using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor (typeof (Generator))]
public class MapGeneratorEditor : Editor {

    public override void OnInspectorGUI()
    {
        Generator mapGen = (Generator)target;
        DrawDefaultInspector();

        if (DrawDefaultInspector() && mapGen.autoUpdate)
        {
            mapGen.GenerateMap();
        }

        if (GUILayout.Button("Generate"))
        {
            mapGen.GenerateMap();
        }
    }
}
