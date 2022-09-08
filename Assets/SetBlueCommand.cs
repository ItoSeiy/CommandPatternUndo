using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBlueCommand : ICommand
{
	private Material _target;

	private float _colorValue;
							 
	public SetBlueCommand(Material target, float colorValue)
	{
		_target = target;
		_colorValue = colorValue;
	}

	public void Execute()
	{
		var setColor = _target.color;
		setColor.b += _colorValue;
		_target.color = setColor;
	}
			   
	public void Undo()
	{
		var setColor = _target.color;
		setColor.b -= _colorValue;
		_target.color = setColor;
	}

}
