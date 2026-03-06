using Common.Enums;

namespace Common.Models;

public class AgentTask
{
    public string Id { get; set; }
    public AgentTypeEnum AgentType { get; set; }
    public string Prompt { get; set; }
    public List<string> Dependents { get; set; } = [];
}