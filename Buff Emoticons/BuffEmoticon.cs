using System;
using System.IO;
using System.IO.Streams;

using Terraria;
using Terraria.ID;
using TerrariaApi.Server;
using TShockAPI;
using TShockAPI.Hooks;

namespace ClassLibrary3
{
    [ApiVersion(1, 21)]
    public class Class1 : TerrariaPlugin
    {

        public override Version Version
        {
            get { return new Version("1.3"); }
        }

        public override string Name
        {
            get { return "Buff Emoticons."; }
        }

        public override string Author
        {
            get { return "Dylan"; }
        }

        public Class1(Main game)
            : base(game)
        {
            Order = 4;
        }
        public override string Description
        {
            get { return "This Plugin give you a Buff when you type a command like /sad u should be get a buff with sad!"; }
        }
        public override void Initialize()
        {
            Commands.ChatCommands.Add(new Command(Love, "love"));
            Commands.ChatCommands.Add(new Command(Mad, "mad"));
            Commands.ChatCommands.Add(new Command(Happy, "happy"));
            Commands.ChatCommands.Add(new Command(Confused, "confused"));
            Commands.ChatCommands.Add(new Command(Sad, "sad"));
            Commands.ChatCommands.Add(new Command(Dreaming, "dream"));
            Commands.ChatCommands.Add(new Command(Freedom, "freedom"));
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        public void Love(CommandArgs e)
        {
            e.Player.SetBuff(119, 2600, true);
        }
        public void Mad(CommandArgs e)
        {
            e.Player.SetBuff(115, 2600, true);
        }
        public void Happy(CommandArgs e)
        {
            e.Player.SetBuff(146, 2600, true);
        }
        public void Confused(CommandArgs e)
        {
            e.Player.SetBuff(31, 2600, true);
        }
        public void Sad(CommandArgs e)
        {
            e.Player.SetBuff(103, 2600, true);
        }
        public void Dreaming(CommandArgs e)
        {
            e.Player.SetBuff(128, 2600, true);
        }
	    public void Freedom(CommandArgs e)
        {
            e.Player.SetBuff(298, 2600, true); // First Buff ID //Second Time In MilliSeconds
        }
    }
}