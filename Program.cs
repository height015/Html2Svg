namespace Html2Svg;

public class Program
{
    static void Main(string[] args)
    {
         // Get desktop path
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, "gen.svg");

        AudioSvgGenerator audioSvgGenerator = new AudioSvgGenerator();
        string svgContent = audioSvgGenerator.GenerateAutoRedirectSvg("");

       
        // Save to desktop
        File.WriteAllText(filePath, svgContent);
        
        Console.WriteLine($"SVG file saved to: {filePath}");

    }
}
