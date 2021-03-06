﻿using System;
using System.Xml.Linq;
using Smellyriver.TankInspector.Pro.Data.Entities;

namespace Smellyriver.TankInspector.Pro.Data.Tank
{
    public class ConfigurationChangedEventArgs : EventArgs
    {
        public ConfigurationAspect Aspect { get; private set; }
        public Component OldValue { get; private set; }
        public Component NewValue { get; private set; }

        public ConfigurationChangedEventArgs(ConfigurationAspect aspect, Component oldValue, Component newValue)
        {
            this.Aspect = aspect;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }
    }
}
