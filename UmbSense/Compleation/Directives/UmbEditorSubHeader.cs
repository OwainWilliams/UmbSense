﻿using Microsoft.VisualStudio.Utilities;
using Microsoft.WebTools.Languages.Html.Editor.Completion.Def;
using System.Collections.Generic;

namespace UmbSense.Compleation.Directives
{
    [HtmlCompletionProvider(CompletionTypes.Children, "umb-editor-container")]
    [ContentType("htmlx")]
    class UmbEditorSubHeader : BaseCompleation
    {
        protected override Dictionary<string, string> values => new Dictionary<string, string>()
        {
            {  "umb-editor-sub-header-content-right", "" },
            {  "umb-editor-sub-header-content-left", "" }
        };
    }

}
