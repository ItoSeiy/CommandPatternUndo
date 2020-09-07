using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{

	[SerializeField] MeshRenderer renderer;

	Material meshMaterial
	{
		get {
			return renderer.material;
		}
	}
	Color meshColor {
		get {
			return meshMaterial.color;
		}
	}

	public void SetBlue()
	{
		var command = new SetBlueCommand(meshColor, meshMaterial);
		command.Execute();
		CommandManager.Instance.AddCommand(command);
	}

	public void SetRed()
	{
		var command = new SetRedCommand(meshMaterial);
		command.Execute();
		CommandManager.Instance.AddCommand(command);
	}

	public void SetGreen()
	{
		var command = new SetGreenCommand(meshColor, meshMaterial);
		command.Execute();
		CommandManager.Instance.AddCommand(command);
	}

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
}
