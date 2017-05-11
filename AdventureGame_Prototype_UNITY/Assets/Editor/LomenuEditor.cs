using System.Collections;
using UnityEditor;
using UnityEngine;

public class LomenuEditor : EditorWindow {

	private static LomenuEditor instance = null;

	[MenuItem("Lomenu UI/Create Aside (2D)")]

	static void CreateAside2D()
	{
		instance = Instantiate(Resources.Load<GameObject>("Aside Layout (2D)")).GetComponent<LomenuEditor>();
	}

	[MenuItem("Lomenu UI/Create Field Layout (3D)")]

	static void CreateField3D()
	{
		instance = Instantiate(Resources.Load<GameObject>("Field Layout (3D)")).GetComponent<LomenuEditor>();
	}

	[MenuItem("Lomenu UI/Create Field Layout (2D)")]

	static void CreateField2D()
	{
		instance = Instantiate(Resources.Load<GameObject>("Field Layout (2D)")).GetComponent<LomenuEditor>();
	}

	[MenuItem("Lomenu UI/Create Flample Layout  (2D)")]

	static void CreateFlample2D()
	{
		instance = Instantiate(Resources.Load<GameObject>("Flample Layout (2D)")).GetComponent<LomenuEditor>();
	}

	public static void OnCustomWindow()
	{
		EditorWindow.GetWindow(typeof(LomenuEditor));
	}
}
