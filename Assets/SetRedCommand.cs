using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRedCommand : ICommand
{
	private Material _target;

	private float _colorValue;

	public SetRedCommand(Material target, float colorValue)
	{
		_target = target;
		_colorValue = colorValue;
	}

	public void Execute()
	{
		var setColor =_target.color;
		setColor.r += _colorValue;
		_target.color = setColor;
	}
			   
	public void Undo()
	{
		var setColor = _target.color;
		setColor.r -= _colorValue;
		_target.color = setColor;
	}

}
