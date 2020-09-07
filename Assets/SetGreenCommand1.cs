using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGreenCommand : ICommand
{
	private Color _before;
	private Material _target;

	public SetGreenCommand(Color before,Material target)
	{
		_before = before;
		_target = target;
	}

	public void Execute()
	{
		var setColor = _before;
		setColor.g += 0.2f;
		_target.color = setColor;
	}
			   
	public void Undo()
	{
		var setColor = _before;
		setColor.g -= 0.2f;
		_target.color = setColor;
	}

}
