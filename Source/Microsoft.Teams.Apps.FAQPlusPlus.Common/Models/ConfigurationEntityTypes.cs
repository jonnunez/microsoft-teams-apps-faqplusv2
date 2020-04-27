// <copyright file="ConfigurationEntityTypes.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.Teams.Apps.FAQPlusPlus.Common.Models
{
    /// <summary>
    /// Configuration entity type names.
    /// This is what appears in the storage table under ROWKEY calumn.
    /// </summary>
    public static class ConfigurationEntityTypes
    {
        /// <summary>
        /// Team entity.
        /// </summary>
        public const string TeamId = "TeamId";

        /// <summary>
        /// Feedback channel entity.
        /// </summary>
        public const string ChannelId = "ChannelId";

        /// <summary>
        /// Request entity.
        /// </summary>
        public const string RequestChannelId = "RequestChannelId";

        /// <summary>
        /// Knowledge base entity.
        /// </summary>
        public const string KnowledgeBaseId = "KnowledgeBaseId";

        /// <summary>
        /// Welcome message entity.
        /// </summary>
        public const string WelcomeMessageText = "WelcomeMessageText";

        /// <summary>
        /// Help tab text entity.
        /// </summary>
        public const string HelpTabText = "HelpTabText";

        /// <summary>
        /// QnaMaker endpoint key entity.
        /// </summary>
        public const string QnAMakerEndpointKey = "QnaMakerEndpointKey";
    }
}
