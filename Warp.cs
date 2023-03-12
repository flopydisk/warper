using PulsarModLoader.Chat.Commands.CommandRouter;

namespace warper
{
    internal class Warp : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[]
            {
                "warp",
                "w"
            };
        }

        public override string Description()
        {
            return "Warps to specified sector";
        }

        public override void Execute(string arguments)
        {
            int.TryParse(arguments, out int Sector);
            PLEncounterManager.Instance.GetCPEI().HandleActivateWarpDrive(PLEncounterManager.Instance.PlayerShip.ShipID, Sector, 0);
            PLServer.Instance.AddNotification(string.Format("warped to:{0}", Sector), PLNetworkManager.Instance.LocalPlayerID, PLServer.Instance.GetEstimatedServerMs() + 2000, false);
        }
    }
}
