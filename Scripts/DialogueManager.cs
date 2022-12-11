using Godot;
using System;

public class DialogueManager : RichTextLabel
{
	public RichTextLabel textbox;
	public int i = 0;
	
	
	public override void _Ready()
	{
		textbox = GetNode<RichTextLabel>("/root/Node2D/CanvasLayer/RichTextLabel");
		textbox.Text = Global.dialogue[i];
	}
	
	public override void _Process(float delta)
	{
		if (Input.IsActionJustReleased("ui_accept"))
		{
			NextPage();
		}
	}
	
	private void _on_NextButton_pressed()
	{
		NextPage();
	}
	
	private void _on_BackButton_pressed()
	{
		PreviousPage();
	}
	
	public void NextPage()
	{
		if (i+1 < Global.dialogue.Length)
		{
			textbox.Text = Global.dialogue[i = i+1];
		}
			
		else
		{
			GD.Print("end");
		}
	}
	
	public void PreviousPage()
	{
		if (i-1 >= 0)
		{
			textbox.Text = Global.dialogue[i= i-1];
		}
		
		else if (i ==0)
		{
			GetTree().ChangeScene("res://Scenes/CoverScene.tscn");
		}
	}
}






