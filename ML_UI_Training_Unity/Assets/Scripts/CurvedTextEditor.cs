using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(scr))] 
public class CurvedTextEditor : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector ();
	}
}
