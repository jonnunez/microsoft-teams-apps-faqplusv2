// <copyright file="ChannelViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.FAQPlusPlus.Configuration.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents TeamViewModel object to store team details.
    /// </summary>
    public class ChannelViewModel
    {
        /// <summary>
        /// Gets or sets team id textbox to be used in View.
        /// </summary>
        [Required(ErrorMessage = "Enter channel id")]
        [MinLength(1)]
        [DataType(DataType.Text)]
        [Display(Name = "Channel ID")]
        [RegularExpression(@"(\S)+", ErrorMessage = "Enter channel id which should not contain any whitespace.")]
        public string ChannelId { get; set; }
    }
}