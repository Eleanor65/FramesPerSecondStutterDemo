using System;
using UnityEngine;

public class Main : MonoBehaviour
{
	[SerializeField] private float _xPositionMin;
	[SerializeField] private float _xPositionMax;

	[SerializeField] private float _speed;

	[SerializeField] private Transform _transformObj;

	private bool _isLongFrame;

	private void Update()
	{
		LogFps();
		MoveObject();
		SetFps();
	}

	private void MoveObject()
	{
		var position = _transformObj.position;
		position += Time.deltaTime * _speed * Vector3.right;

		if (position.x > _xPositionMax)
		{
			position.x = _xPositionMin;
		}

		_transformObj.position = position;
	}

	private void SetFps()
	{
		_isLongFrame = !_isLongFrame;
		if (!_isLongFrame)
			return;

		var timeEnd = DateTime.Now.AddMilliseconds(33);
		while (DateTime.Now < timeEnd)
		{
			
		}
	}

	private void LogFps()
	{
		Debug.Log($"Fps = {Mathf.RoundToInt(1 / Time.deltaTime)}");
	}
}