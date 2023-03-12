using PulsarModLoader.Chat.Commands.CommandRouter;

namespace warper
{
    internal class SkipWarp : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[]
            {
                "skipwarp",
                "sw"
            };
        }

        public override string Description()
        {
            return "Skips current warp";
        }

        public override void Execute(string arguments)
        {
            PLEncounterManager.Instance.PlayerShip.photonView.RPC("SkipWarp", 0, new object[0]);
        }
    }
}
