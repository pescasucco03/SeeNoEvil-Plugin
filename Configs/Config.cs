namespace UIURescueSquad.Configs
{
    using System.ComponentModel;
    using Exiled.API.Interfaces;
    using SubConfigs;

    /// <inheritdoc cref="IConfig"/>
    public class Config : IConfig
    {
        /// <inheritdoc/>
        [Description("Is the plugin enabled.")]
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether debug mode is enabled.
        /// </summary>
        [Description("Should debug messages be shown in a server console.")]
        public bool Debug { get; set; } = false;

        /// <summary>
        /// Gets a <see cref="SpawnManager"/> configs.
        /// </summary>
        [Description("Options for UIU spawn:")]
        public SpawnManager SpawnManager { get; private set; } = new SpawnManager();

        /// <summary>
        /// Gets a <see cref="UiuLeader"/> configs.
        /// </summary>
        [Description("Options for UIU Leader:")]
        public SeeNoEvilLeader UiuLeader { get; private set; } = new SeeNoEvilLeader();

        /// <summary>
        /// Gets a <see cref="UiuAgent"/> configs.
        /// </summary>
        [Description("Options for UIU Agent:")]
        public SeeNoEvilAgent UiuAgent { get; private set; } = new SeeNoEvilAgent();

        /// <summary>
        /// Gets a <see cref="SeeNoEvilSoldier"/> configs.
        /// </summary>
        [Description("Options for UIU Soldier:")]
        public SeeNoEvilSoldier SeeNoEvilSoldier { get; private set; } = new SeeNoEvilSoldier();

        /// <summary>
        /// Gets a <see cref="TeamColors"/> configs.
        /// </summary>
        [Description("Options for custom team colors:")]
        public TeamColors TeamColors { get; private set; } = new TeamColors();

        /// <summary>
        /// Gets a <see cref="SupplyDrop"/> configs.
        /// </summary>
        [Description("Option for UIU supply drop:")]
        public SupplyDrop SupplyDrop { get; private set; } = new SupplyDrop();
    }
}