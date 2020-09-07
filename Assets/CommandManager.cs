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

	int nowIndex = -1;

	private void Awake()
	{
		_instance = this;
	}

	public void AddCommand(ICommand command)
	{
		_commandBuffer.Add(command);
		nowIndex++;
	}

	public void Undo()
	{
		if (nowIndex == -1)return;
		_commandBuffer[nowIndex].Undo();
		nowIndex--;
	}

	public void Redo()
	{
		if (_commandBuffer.Count < nowIndex + 1) return;
		_commandBuffer[nowIndex].Execute();
		nowIndex++;
	}

}
