//Copyright 2023 (c) Floppydisk
//GPL 3.0-only
using PulsarModLoader.Chat.Commands.CommandRouter;

namespace warper
{
    internal class SetCourse : ChatCommand
    {
        public override string[] CommandAliases()
        {
            return new string[]
            {
                "setcourse",
                "sc"
            };
        }

        public override string Description()
        {
            return "Warps to specified sector using RPC";
        }

        public override void Execute(string arguments)
        {
            int.TryParse(arguments, out int Sector);
            PLServer.Instance.photonView.RPC("AddCourseGoal", 0, new object[]
            {
                Sector
            });
        }
    }
}
