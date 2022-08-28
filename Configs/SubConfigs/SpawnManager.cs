namespace UIURescueSquad.Configs.SubConfigs
{
    using System.ComponentModel;
    using UnityEngine;

    /// <summary>
    /// Configs for UIU spawning options.
    /// </summary>
    public class SpawnManager
    {
        /// <summary>
        /// Gets the number of respawn waves which must occur before considering UIU to spawn.
        /// </summary>
        [Description("How many mtfs respawns must have happened to spawn UIU")]
        public int Respawns { get; private set; } = 1;

        /// <summary>
        /// Gets the chance for UIU to spawn instead of NTF.
        /// </summary>
        [Description("Probability of a UIU Squad replacing a MTF spawn")]
        public int Probability { get; private set; } = 80;

        /// <summary>
        /// Gets the maximum size of a UIU squad.
        /// </summary>
        [Description("The maximum size of a UIU squad")]
        public uint MaxSquad { get; private set; } = 1;

        /// <summary>
        /// Gets the UIU spawn position.
        /// </summary>
        [Description("UIU Rescue squad spawn position:")]
        public Vector3 SpawnPos { get; private set; } = new Vector3(170f, 985f, 29f);

        /// <summary>
        /// Gets the UIU announcement message.
        /// </summary>
        [Description("Entrance broadcast announcement message (null to disable it)")]
        public string AnnouncementText { get; private set; } = "Sei un SeeNoEvil, il tuo compito è quello di ricontenere gli SCP più pericolosi della struttura";

        /// <summary>
        /// Gets the UIU announcement message display time.
        /// </summary>
        [Description("Entrance broadcast announcement message time")]
        public ushort AnnouncementTime { get; private set; } = 12;

        /// <summary>
        /// Gets the UIU Cassie entrance message.
        /// </summary>
        [Description("UIU entrance Cassie Message")]
        public string UiuAnnouncementCassie { get; private set; } = "MTFUnit .g4 pitch_1.02 ETA jam_030_3 10 designated {designation} HasEntered allremaining AwaitingRecontainment {scpnum} SCPSubject\n";

        /// <summary>
        /// Gets the UIU Cassie entrance message, when there aren't any SCPs.
        /// </summary>
        public string UiuAnnouncmentCassieNoScp { get; private set; } = "MTFUnit .g4 pitch_1.02 ETA jam_030_3 10 designated {designation} HasEntered NoSCPsLeft";

        /// <summary>
        /// Gets the custom NTF Cassie entrance message.
        /// </summary>
        [Description("NTF entrance Cassie Message (leave empty to use default NTF cassie entrance)")]
        public string NtfAnnouncementCassie { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the custom NTF Cassie entrance message, when there aren't any SCPs.
        /// </summary>
        public string NtfAnnouncmentCassieNoScp { get; private set; } = string.Empty;

        /// <summary>
        /// Gets the Cassie glitch chance for custom announcements.
        /// </summary>
        [Description("Custom Cassie glitch chance.")]
        public float GlitchChance { get; private set; } = 0.05f;

        /// <summary>
        /// Gets the Cassie glitch chance for custom announcements.
        /// </summary>
        [Description("Custom Cassie jam chance.")]
        public float JamChance { get; private set; } = 0.05f;

        /// <summary>
        /// Gets a value indicating whether hints should be used instead of broadcasts.
        /// </summary>
        [Description("Use hints instead of broadcasts.")]
        public bool UseHints { get; private set; } = false;

        /// <summary>
        /// Gets an UIU spawn broadcast.
        /// </summary>
        [Description("UIU Player broadcast (null to disable it)")]
        public string UiuBroadcast { get; private set; } = "<i>Sei un</i><color=yellow><b>SeeNoEvil</b></color>, <i>Aiuta gli </i><color=#0377fc><b>MTFs</b></color><i> a ricontenere gli</b></color><i>SCP più pericolosi.</i>";

        /// <summary>
        /// Gets an UIU spawn broadcast time.
        /// </summary>
        [Description("UIU Player broadcast time")]
        public ushort UiuBroadcastTime { get; private set; } = 12;
    }
}
