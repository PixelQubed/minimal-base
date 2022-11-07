using System;
using System.Linq;
using Sandbox;

namespace GamemodeName
{
	public class Player : Sandbox.Player
	{
		ClothingContainer Clothing { get; } = new();

		public Player()
		{
			
		}
		
		public Player( Client cl )
		{
			Clothing.LoadFromClient( cl );
		}

		public override void Respawn()
		{
			SetModel( "models/citizen/citizen.vmdl" );

			Controller = new WalkController();
			Animator = new StandardPlayerAnimator();
			CameraMode = new ThirdPersonCamera();

			Clothing.DressEntity( this );

			EnableAllCollisions = true;
			EnableDrawing = true;
			EnableHideInFirstPerson = true;
			EnableShadowInFirstPerson = true;
        
			base.Respawn();
		}
		
	}
	
}
