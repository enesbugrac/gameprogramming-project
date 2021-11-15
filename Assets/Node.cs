using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
	public Color hoverColor;
	private Renderer rend;
	private Color startColor;
	public GameObject turret;
	public Vector3 positionOffset;


	void Start()
	{
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
	}
	
	void OnMouseDown()
	{
		

		if (turret != null)
		{
			return;
		}
		GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
		turret = Instantiate(turretToBuild, transform.position+positionOffset, transform.rotation);

	}
	void OnMouseEnter()
	{
			rend.material.color = hoverColor;
	}

	void OnMouseExit()
	{
		rend.material.color = startColor;
	}
}
