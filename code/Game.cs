using Sandbox;

namespace MinimalBase
{
	public class Game : Sandbox.Game
	{
		public override void ClientJoined( Client client )
		{
			base.ClientJoined( client );

			var pawn = new Player( client );
			client.Pawn = pawn;
			pawn.Respawn();
		}
	}
}
