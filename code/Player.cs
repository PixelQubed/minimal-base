using Sandbox;

namespace MinimalBase
{
	public class Player : Sandbox.Player
	{
		public Player()
		{

		}

		public Player( Client cl )
		{
			Clothing.LoadFromClient( cl );
		}
		
		ClothingContainer Clothing { get; } = new();

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
