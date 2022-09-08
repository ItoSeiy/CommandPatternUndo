using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetColor : MonoBehaviour
{

	[SerializeField] MeshRenderer renderer;

	Material meshMaterial
	{
		get {
			return renderer.material;
		}
	}

	public void SetBlue(float targetColorValue)
	{
		var command = new SetBlueCommand(meshMaterial, targetColorValue);
		command.Execute();
		CommandManager.Instance.AddCommand(command);
	}

	public void SetRed(float targetColorValue)
	{
		var command = new SetRedCommand(meshMaterial, targetColorValue);
		command.Execute();
		CommandManager.Instance.AddCommand(command);
	}

	public void SetGreen(float targetColorValue)
	{
		var command = new SetGreenCommand(meshMaterial, targetColorValue);
		command.Execute();
		CommandManager.Instance.AddCommand(command);
	}

}
