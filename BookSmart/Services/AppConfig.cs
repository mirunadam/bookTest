using System.Text.Json;

namespace BookSmart.Services;

public class AppConfig
{
    public int DefaultRentalDays { get; set; } = 14;
    public double FeePerDay { get; set; } = 1.5;
    public string DataFolder { get; set; } = "Data";
}

public static class ConfigService
{
    private static AppConfig _config;
    public static AppConfig Config => _config ??= Load();

    public static AppConfig Load()
    {
        var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "config.json");
        
        Directory.CreateDirectory(Path.GetDirectoryName(path)!);    //ensure data folder exists

        // if config doesnt exist create it
        if (!File.Exists(path))
        {
            var defaultCfg = new AppConfig();

            var json = JsonSerializer.Serialize(defaultCfg,
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(path, json);

            return defaultCfg;
        }

        // load existing config
        var content = File.ReadAllText(path);
        return JsonSerializer.Deserialize<AppConfig>(content)
               ?? new AppConfig(); // fallback safety
    }
}