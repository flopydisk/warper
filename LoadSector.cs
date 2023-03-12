using PulsarModLoader.Chat.Commands.CommandRouter;
using System;

namespace warper
{
    internal class LoadSector : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[]
            {
                "loadsector",
                "ls"
            };
        }

        public override string Description()
        {
            return "Warps to specified sector using RPC";
        }

        public override void Execute(string arguments)
        {
            PLServer.Instance.photonView.RPC("ClientSetCurrentSectorID", 0, new object[]
            {
                arguments
            });
        }
    }
}
