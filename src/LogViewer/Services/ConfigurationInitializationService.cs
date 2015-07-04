﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfigurationInitializationService.cs" company="Wild Gums">
//   Copyright (c) 2008 - 2015 Wild Gums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace LogViewer.Services
{
    using Catel;
    using Catel.Configuration;

    internal class ConfigurationInitializationService : IConfigurationInitializationService
    {
        private readonly IConfigurationService _configurationService;

        public ConfigurationInitializationService(IConfigurationService configurationService)
        {
            Argument.IsNotNull(() => configurationService);

            _configurationService = configurationService;
        }

        public void Initialize()
        {
            // General
            InitializeConfigurationKey(Settings.Application.General.EnableAnalytics, Settings.Application.General.EnableAnalyticsDefaultValue);
        }

        private void InitializeConfigurationKey(string key, object defaultValue)
        {
            _configurationService.InitializeValue(key, defaultValue);
        }
    }
}