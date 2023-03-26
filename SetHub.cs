//Copyright 2023 (c) Floppydisk
//GPL 3.0-only
using PulsarModLoader.Chat.Commands.CommandRouter;

namespace warper
{
    internal class SetHub : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[]
            {
                "sethub",
                "sh"
            };
        }

        public override string Description()
        {
            return "Sets the hub of the client";
        }

        public override void Execute(string arguments)
        {
            int.TryParse(arguments, out var hubId);
            PLServer.Instance.photonView.RPC("ClientLoadHubID", 0, new object[]
            {
                arguments
            }) ;     
        }
    }
}
