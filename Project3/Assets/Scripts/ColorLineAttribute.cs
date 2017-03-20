using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ColorLineAttribute : PropertyAttribute
{
	public ColorLineAttribute(float r, float g, float b)
	{
		Color lineColor = new Color (r, g, b);
	}
}

[CustomPropertyDrawer(typeof(ColorLineAttribute))]
public class ColorLineDrawer : DecoratorDrawer
{
	public override void OnGUI (UnityEngine.Rect position)
	{
		DrawLine (50.0F, 50.0F, 50.0F, position);
		//base.OnGUI (position);
	}

	public override float GetHeight ()
	{
		return base.GetHeight () * 2;
	}

	public void DrawLine(float r, float g, float b, Rect position)
	{
		Color lineColor = new Color (r, g, b);
		GUI.color = lineColor;
		GUIStyle myStyle = new GUIStyle ();
		myStyle.alignment = TextAnchor.MiddleCenter;
		GUI.Label (position, "________________________________________", myStyle);
	}
}