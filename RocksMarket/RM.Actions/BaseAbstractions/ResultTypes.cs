namespace RM.Actions.BaseAbstractions
{
    
    public record Result (ResultStatus Status, string Message = null);
    
    public record ValueResult<T> : Result
    {
        public T Value { get; init; }

        public ValueResult(T value, ResultStatus status, string message = null) : base(status, message)
        {
            Value = value;
        }
    }
}