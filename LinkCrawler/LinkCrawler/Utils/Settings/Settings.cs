﻿using LinkCrawler.Utils.Extensions;
using System.Configuration;
using System.Net;

namespace LinkCrawler.Utils.Settings
{
    public class Settings : ISettings
    {
        public string BaseUrl =>
            ConfigurationManager.AppSettings[Constants.AppSettings.BaseUrl].Trim('/');

        public string ValidUrlRegex =>
            ConfigurationManager.AppSettings[Constants.AppSettings.ValidUrlRegex];

        public bool CheckImages =>
            ConfigurationManager.AppSettings[Constants.AppSettings.CheckImages].ToBool();

        public bool OnlyReportBrokenLinksToOutput =>
            ConfigurationManager.AppSettings[Constants.AppSettings.OnlyReportBrokenLinksToOutput].ToBool();

        public string SlackWebHookUrl =>
            ConfigurationManager.AppSettings[Constants.AppSettings.SlackWebHookUrl];

        public string SlackWebHookBotName =>
            ConfigurationManager.AppSettings[Constants.AppSettings.SlackWebHookBotName];

        public string SlackWebHookBotIconEmoji =>
            ConfigurationManager.AppSettings[Constants.AppSettings.SlackWebHookBotIconEmoji];

        public string SlackWebHookBotMessageFormat =>
            ConfigurationManager.AppSettings[Constants.AppSettings.SlackWebHookBotMessageFormat];

        public string CsvFilePath =>
            ConfigurationManager.AppSettings[Constants.AppSettings.CsvFilePath];

        public bool CsvOverwrite =>
            ConfigurationManager.AppSettings[Constants.AppSettings.CsvOverwrite].ToBool();

        public string CsvDelimiter =>
            ConfigurationManager.AppSettings[Constants.AppSettings.CsvDelimiter];

        public bool IsSuccess(HttpStatusCode statusCode)
        {
            var configuredCodes = ConfigurationManager.AppSettings[Constants.AppSettings.SuccessHttpStatusCodes] ?? "";
            return statusCode.IsSuccess(configuredCodes);
        }

        public string CouchbaseConnectionString =>
            ConfigurationManager.AppSettings[Constants.AppSettings.CouchbaseConnectionString];
        public string CouchbaseBucketName =>
            ConfigurationManager.AppSettings[Constants.AppSettings.CouchbaseBucketName];
        public string CouchbaseBucketPassword =>
            ConfigurationManager.AppSettings[Constants.AppSettings.CouchbaseBucketPassword];
    }
}
