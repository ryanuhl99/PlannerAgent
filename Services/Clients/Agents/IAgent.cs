using Common.Enums;
using Common.Models;

namespace Services.Clients.Agents;

public interface IAgent
{
    AgentTypeEnum Type { get; }
    Task<AgentResponse> ExecuteAsync(AgentTask task);
}