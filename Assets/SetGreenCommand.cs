using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGreenCommand : ICommand
{
	private Material _target;

	public SetGreenCommand(Material target)
	{
		_target = target;
	}

	public void Execute()
	{
		var setColor = _target.color;
		setColor.g += 0.2f;
		_target.color = setColor;
	}
			   
	public void Undo()
	{
		var setColor = _target.color;
		setColor.g -= 0.2f;
		_target.color = setColor;
	}

}
