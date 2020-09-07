using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
	private static CommandManager _instance;
	public static CommandManager Instance
	{
		get
		{
			if (_instance == null)
			{
				//もし_instance == nullならばシーンからとってくる
				return FindObjectOfType<CommandManager>() as CommandManager;
			}
			return _instance;
		}
	}

	private List<ICommand> _commandBuffer = new List<ICommand>();

	int nowIndex = 0;

	private void Awake()
	{
		_instance = this;
	}

	public void AddCommand(ICommand command)
	{
		if (_commandBuffer.Count > nowIndex) {
			_commandBuffer.RemoveRange(nowIndex, _commandBuffer.Count - nowIndex);
		}

		_commandBuffer.Add(command);
		nowIndex++;
	}

	public void Undo()
	{
		if (nowIndex == 0) return;
		nowIndex--;
		_commandBuffer[nowIndex].Undo();
		Debug.Log("undo :" + nowIndex);
	}

	public void Redo()
	{
		if (_commandBuffer.Count == nowIndex) return;
		_commandBuffer[nowIndex].Execute();
		nowIndex++;
		Debug.Log("Redo :" + nowIndex);
	}

}
