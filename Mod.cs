//Copyright 2023 (c) Floppydisk
//GPL 3.0-only
using PulsarModLoader;

namespace warper
{
    public class Mod : PulsarMod {
        public override string HarmonyIdentifier()
        {
            return "FloppyDisk.Warper";
        }
        public override string Version
        {
            get
            {
                return "0.0.1";
            }
        }

        public override string Author
        {
            get
            {
                return "FloppyDisk";
            }
        }
        public override string Name
        {
            get
            {
                return "Warper";
            }
        }

        public override string ShortDescription
        {
            get
            {
                return "Varoius Warp commands";
            }
        }

        public override string LongDescription
        {
            get
            {
                return "warp(w),rpcwarp(rw),skipwarp(sw),sethub(sh),loadsector(ls),blindjump(bj),setcourse(sc)\nLicence: GPL 3.0 only";
            }
        }
    }
}
