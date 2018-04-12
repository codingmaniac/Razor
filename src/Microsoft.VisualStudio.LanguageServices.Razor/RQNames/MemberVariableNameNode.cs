﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.VisualStudio.LanguageServices.Razor.RQNames
{
    internal class MemberVariableNameNode : SymbolNameNode
    {
        public MemberVariableNameNode(SimpleNameNode simpleName)
        {
            SimpleName = simpleName;
        }

        public SimpleNameNode SimpleName { get; }

        public override string Name => SimpleName.Text;
    }
}