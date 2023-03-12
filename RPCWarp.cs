using PulsarModLoader.Chat.Commands.CommandRouter;

namespace warper
{
    internal class RPCWarp : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[]
            {
                "rpcwarp",
                "rw"
            };
        }

        public override string Description()
        {
            return "Warps to specified sector using RPC";
        }

        public override void Execute(string arguments)
        {
            int.TryParse(arguments, out int Sector);
            PLServer.Instance.photonView.RPC("NetworkBeginWarp", 0, new object[]
            {
                PLEncounterManager.Instance.PlayerShip.ShipID,
                Sector,
                PLServer.Instance.GetEstimatedServerMs(),
                -1
            });
        }
    }
}
