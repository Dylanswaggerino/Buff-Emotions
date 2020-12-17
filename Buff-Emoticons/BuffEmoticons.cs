using System;

using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace BuffEmoticons
{
    [ApiVersion(2, 1)]
    public class BuffEmoticons : TerrariaPlugin
    {

        public override Version Version
        {
            get { return new Version("2.1"); }
        }

        public override string Name
        {
            get { return "Buff Emoticons."; }
        }

        public override string Author
        {
            get { return "Dylan 'The Killer [NL]'"; }
        }

        public BuffEmoticons(Main game)
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
            Commands.ChatCommands.Add(new Command(Gravity, "gravity"));
            Commands.ChatCommands.Add(new Command(Peace, "peace"));
            Commands.ChatCommands.Add(new Command(Hidden, "hidden"));
            Commands.ChatCommands.Add(new Command(Calm, "calm"));
            Commands.ChatCommands.Add(new Command(Sexy, "sexy"));
            Commands.ChatCommands.Add(new Command(Oof, "oof"));
            Commands.ChatCommands.Add(new Command(Goat, "goat"));
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
        public void Gravity(CommandArgs e)
        {
            e.Player.SetBuff(18, 2600, true); // First Buff ID //Second Time In MilliSeconds
        }
        public void Peace(CommandArgs e)
        {
            e.Player.SetBuff(157, 1200, true); // First Buff ID //Second Time In MilliSeconds
        }
        public void Hidden(CommandArgs e)
        {
            e.Player.SetBuff(10, 2600, true); // First Buff ID //Second Time In MilliSeconds
        }
        public void Calm(CommandArgs e)
        {
            e.Player.SetBuff(106, 2600, true); // First Buff ID //Second Time In MilliSeconds
        }
        public void Sexy(CommandArgs e)
        {
            e.Player.SetBuff(193, 2600, true); // First Buff ID //Second Time In MilliSeconds
        }
        public void Oof(CommandArgs e)
        {
            e.Player.SetBuff(17, 2600, true); // First Buff ID //Second Time In MilliSeconds
        }
        public void Goat(CommandArgs e)
        {
            e.Player.SetBuff(282, 2600, true); // First Buff ID //Second Time In MilliSeconds
        }
    }
}