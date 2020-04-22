using Microsoft.ApplicationInsights;
using System.Collections.Generic;
using Microsoft.Bot.Schema;

namespace Microsoft.Teams.Apps.FAQPlusPlus.Helpers
{
    public class TrackEvents
    {
        static TelemetryClient telemetry = new TelemetryClient();
        static TelemetryClient telemetryConversation = new TelemetryClient();

        public static void TrackEvent(string lastSearchedText, string lastAnswerText, string feedbackvalue, string Conversationtype, ChannelAccount from = null)
        {
            var properties = new Dictionary<string, string>
                        {
                              {"Question", lastSearchedText },
                              {"Answer",lastAnswerText},
                              {"Vote", feedbackvalue },
                              {"Conversation Type", Conversationtype},
                        };
            if (from != null)
            {
                properties.Add("Username", from.Id);
                properties.Add("Email", from.Name);
            }

            telemetry.TrackEvent(feedbackvalue + "- Feedback", properties);
        }

        //public static void TrackConversation(string lastSearchedText = "N/A", string lastAnswerText = "N/A", string Conversationtype="N/A", string score = "N/A", string intent = "N/A", string Id = "N/A", string Name = "N/A")
        public static void TrackConversation(string lastSearchedText = "N/A", string lastAnswerText = "N/A", string Conversationtype = "N/A", string score = "N/A", string intent = "N/A", ChannelAccount from = null)
        {
            var properties = new Dictionary<string, string>
                        {
                              {"Question", lastSearchedText },
                              {"Answer",lastAnswerText  },
                              {"Conversation Type", Conversationtype},
                              {"Confidence Score", score},
                              {"Intent", intent},
                              //{"Name", Id},
                              //{"Email", Name}

                        };
            if (from != null)
            {
                properties.Add("Username", from.Id);
                properties.Add("Email", from.Name);
            }

            telemetryConversation.TrackEvent(Conversationtype + "- Conversation Type", properties);
        }

        public static void UserInfo(string lastSearchedText = "N/A", string lastAnswerText = "N/A", string Conversationtype = "N/A", string score = "N/A", string intent = "N/A")
        {
            var properties = new Dictionary<string, string>
                        {
                              {"Name", lastSearchedText },
                              {"E-mail",lastAnswerText  },

                        };
            telemetryConversation.TrackEvent(Conversationtype + "- Conversation Type", properties);
        }
    }
}
