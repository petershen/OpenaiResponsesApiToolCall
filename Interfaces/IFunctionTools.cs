namespace OpenaiResponsesApiToolCall.Interfaces
{
    internal interface IFunctionTools
    {
        object[] Definition();
        Task<object> Implementation(string? toolName, string? argsJson) ;
    }
}
