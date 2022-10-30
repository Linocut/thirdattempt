using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
	public SpriteRenderer room;

	// Use this for initialization
	void Start()
	{
		Camera.main.orthographicSize = room.bounds.size.y / 2;
	}
}