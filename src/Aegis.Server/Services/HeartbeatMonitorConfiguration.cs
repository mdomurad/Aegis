namespace Aegis.Server.Services;

/// <summary>
/// Represents the configuration settings for the heartbeat monitor.
/// </summary>
public class HeartbeatMonitorConfiguration
{
    /// <summary>
    /// Gets or sets the interval at which the heartbeat check is performed.
    /// Default is 5 minutes.
    /// </summary>
    public TimeSpan CheckInterval { get; set; } = TimeSpan.FromMinutes(5);

    /// <summary>
    /// Gets or sets the timeout duration after which a heartbeat is considered missed.
    /// Default is 10 minutes.
    /// </summary>
    public TimeSpan HeartbeatTimeout { get; set; } = TimeSpan.FromMinutes(10);
}
