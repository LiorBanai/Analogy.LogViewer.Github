﻿using Analogy.LogViewer.Github.Managers;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.LogViewer.Github.IAnalogy
{
    public class GitHubDataProviderSettings : Template.UserSettingsFactory
    {
        public override Guid FactoryId { get; set; } = PrimaryFactory.Id;
        public override Guid Id { get; set; } = new Guid("2B46268B-0BB7-4D3B-9ED1-8E3C5B206F2F");
        public override string Title { get; set; } = "GitHub settings";
        public override UserControl DataProviderSettings { get; set; } = new GitRepositoriesSettings();
        public override Image? SmallImage { get; set; }
        public override Image? LargeImage { get; set; }

        public override Task SaveSettingsAsync()
        {
            UserSettingsManager.UserSettings.Save();
            return Task.CompletedTask;
        }
    }
}
