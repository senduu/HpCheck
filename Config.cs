using System.ComponentModel;
using Exiled.API.Interfaces;

namespace HpCheck
{
    public sealed class Config : IConfig
    {
        [Description("Включен ли плагин")]
        public bool IsEnabled { get; set; } = true;

        [Description("Включен ли дебагмод")]
        public bool Debug { get; set; } = false;
    }
}
