using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterDiscordPluginCleaner
{
    internal class DiscordPlugin
    {
        public string PluginName { get; private set; }
        public FileInfo PluginFile { get; private set; }
        public FileInfo ConfigFile { get; private set; }
        public FileInfo CSSFile { get; private set; }
        public FileInfo DataFile { get; private set; }
        public DiscordPlugin(string filePath)
        {
            if (!File.Exists(filePath) || !filePath.EndsWith(".plugin.js")) throw new ApplicationException($"No valid file found at \"{filePath}\"");
            string fileWithoutExtensions = filePath.Remove(filePath.Length - 10, 10);
            PluginName = Path.GetFileName(fileWithoutExtensions);
            PluginFile = new FileInfo(filePath);
            ConfigFile = new FileInfo($"{fileWithoutExtensions}.config.json");
            CSSFile = new FileInfo($"{fileWithoutExtensions}.raw.css");
            DataFile = new FileInfo($"{fileWithoutExtensions}.data.json");

        }

    }
}
