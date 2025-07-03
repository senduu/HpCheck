using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using static Broadcast;

namespace HpCheck
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "senduu";
        public override string Name => "HpCheck";
        public override string Prefix => "HC";
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Hurt += OnHurting;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Hurt -= OnHurting;

            base.OnDisabled();
        }

        public void OnHurting(HurtEventArgs ev)
        {
            var X = ev.Player.Health;

            ev.Attacker.Broadcast(1, ev.Player.Nickname + " HP: " + X.ToString(), BroadcastFlags.Normal, true);
        }
    }
}