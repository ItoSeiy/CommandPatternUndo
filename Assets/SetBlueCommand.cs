using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBlueCommand : ICommand
{
	private Color _before;
	private Material _target;
							 
	public SetBlueCommand(Color before,Material target)
	{
		_before = before;
		_target = target;
	}

	public void Execute()
	{
		var setColor = _before;
		setColor.b += 0.2f;
		_target.color = setColor;
	}
			   
	public void Undo()
	{
		var setColor = _before;
		setColor.b -= 0.2f;
		_target.color = setColor;
	}

}
