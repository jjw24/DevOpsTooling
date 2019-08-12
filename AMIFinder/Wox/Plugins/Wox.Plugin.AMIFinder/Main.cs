using System.Collections.Generic;
using System.Windows.Controls;
using Wox.Infrastructure.Storage;
using Wox.Plugin.AMIFinder.Commands;

namespace Wox.Plugin.AMIFinder
{
    public class Main : ISettingProvider,IPlugin, IPluginI18n, ISavable
    {
        private PluginInitContext context;
        private readonly Settings _settings;
        private readonly PluginJsonStorage<Settings> _storage;

        public Main()
        {
            _storage = new PluginJsonStorage<Settings>();
            _settings = _storage.Load();
        }

        public void Save()
        {
            _storage.Save();
        }

        public List<Result> Query(Query query)
        {
            // convert to settings
            var profile = "DemoProfile";
            var region = "ap-southeast-2";

            return profile.LoadList(region);
        }

        public Control CreateSettingPanel()
        {
            return new SettingsControl(context.API,_settings);
        }        

        public void Init(PluginInitContext context)
        {
            this.context = context;
        }

        public string GetTranslatedPluginTitle()
        {
            return context.API.GetTranslation("wox_plugin_amifinder_plugin_name");
        }

        public string GetTranslatedPluginDescription()
        {
            return context.API.GetTranslation("wox_plugin_amifinder_plugin_description");
        }
    }
}