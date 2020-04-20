// <copyright file="TeamViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.FAQPlusPlus.Configuration.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents TeamViewModel object to store team details.
    /// </summary>
    public class TeamViewModel2
    {
        /// <summary>
        /// Gets or sets team id textbox to be used in View.
        /// </summary>
        [Required(ErrorMessage = "Enter team id 2.")]
        [MinLength(1)]
        [DataType(DataType.Text)]
        [Display(Name = "Team ID 2")]
        [RegularExpression(@"(\S)+", ErrorMessage = "Enter team id 2 which should not contain any whitespace.")]
        public string TeamId2 { get; set; }
    }
}