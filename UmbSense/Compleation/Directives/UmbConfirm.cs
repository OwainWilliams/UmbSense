﻿using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;

using System.Collections.Generic;

namespace UmbSense.Compleation.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Attributes, "umb-confirm")]
    [ContentType("htmlx")]
    class UmbConfirm : BaseCompleation
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            { "caption", "The caption shown above the buttons" },
            { "on-confirm", "The call back when the \"OK\" button is clicked" },
            { "on-cancel", "The call back when the \"Cancel\" button is clicked" }
        };
    }
}
