using Godot;
using System;

public class TextureButton : Godot.TextureButton
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}
	
	private void _on_TextureButton_pressed()
	{
		GetTree().ChangeScene("res://Scenes/MainScene.tscn");
	}

}


