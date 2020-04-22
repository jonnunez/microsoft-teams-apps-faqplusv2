// <copyright file="TeamViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.FAQPlusPlus.Configuration.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Represents TeamViewModel object to store team details.
    /// </summary>
    public class TeamViewModel
    {
        /// <summary>
        /// Gets or sets experts channel id textbox to be used in View.
        /// </summary>
        [Required(ErrorMessage = "Enter experts channel id.")]
        [MinLength(1)]
        [DataType(DataType.Text)]
        [Display(Name = "Experts Channel ID")]
        [RegularExpression(@"(\S)+", ErrorMessage = "Enter experts channel id which should not contain any whitespace.")]
        public string TeamId { get; set; }
    }
}