//Copyright 2023 (c) Floppydisk
//GPL 3.0-only
using PulsarModLoader.Chat.Commands.CommandRouter;

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
            return "Set Current Sector";
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
