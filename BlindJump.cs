//Copyright 2023 (c) Floppydisk
//GPL 3.0-only
using PulsarModLoader.Chat.Commands.CommandRouter;

namespace warper
{
    internal class BlindJump : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[]
            {
                "blindjump",
                "bj"
            };
        }

        public override string Description()
        {
            return "Blind Jump";
        }

        public override void Execute(string arguments)
        {
            PLServer.Instance.photonView.RPC("UnlockBlindJump", 0, new object[]
            {
                PLEncounterManager.Instance.PlayerShip.ShipID
            });
            PLServer.Instance.photonView.RPC("AttemptBlindJump", 0, new object[]
            {
                PLEncounterManager.Instance.PlayerShip.ShipID,
                0
            });
        }
    }
}
