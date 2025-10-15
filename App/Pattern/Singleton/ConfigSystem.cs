using FirstProject.App.Contracts;

namespace FirstProject.App.Pattern.Singleton;

class ConfigSystem : ISingleton
{
    private Dictionary<string, string> memory = new Dictionary<string, string>();

    private static ConfigSystem? _instance;

    private static Logger? _log;


    private ConfigSystem()
    {
        _log = Logger.GetInstance();
    }

    private void _logMessage(string message)
    {
        _log?.Message(message);
    }

    public static ConfigSystem GetInstance()
    {
        if (_instance == null)
        {
            _instance = new ConfigSystem();
        }
        return _instance;
    }

    public void Set(string key, string value)
    {
        if (memory.ContainsKey(key) && memory[key] == value)
        {
            this._logMessage($"the Value {value}  alredy exist in index {key}");
        }
        else
        {
            this._logMessage($"The new value {value} has ben set with key {key}");
            memory[key] = value;
        }
    }



    public string Get(string key)
    {
        return memory.ContainsKey(key) ? memory[key] : "";
    }

    public void PrintMemories()
    {
        foreach(var elem in memory)
        {
            this._logMessage($"The key {elem.Key} has value: {elem.Value}");
        }
    }

}
