public class Calculator
{
    private readonly ILogRepository _logRepository;

    public Calculator(ILogRepository logRepository)
    {
        _logRepository = logRepository;
    }

    public int Add(int a, int b, bool logOperation)
    {
        var result = a + b;

        if (logOperation)
            _logRepository.LogOperation();

        return result;
    }
}
