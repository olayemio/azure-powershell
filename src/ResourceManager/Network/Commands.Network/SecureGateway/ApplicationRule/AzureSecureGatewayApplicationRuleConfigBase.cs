﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Network.Models;
using System.Management.Automation;
using MNM = Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Commands.Network
{
    using System.Collections.Generic;

    public class AzureSecureGatewayApplicationRuleConfigBase : NetworkBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The name of the Application Rule")]
        [ValidateNotNullOrEmpty]
        public virtual string Name { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The priority of the rule")]
        [ValidateNotNullOrEmpty]
        public uint Priority { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The description of the rule")]
        [ValidateNotNullOrEmpty]
        public string Description { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The direction of the rule")]
        [ValidateNotNullOrEmpty]
        [ValidateSet( 
            MNM.SecureGatewayRuleDirection.Inbound,
            MNM.SecureGatewayRuleDirection.Outbound,
            IgnoreCase = true)]
        public string Direction { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The protocols of the rule")]
        [ValidateNotNullOrEmpty]
        public List<PSSecureGatewayApplicationRuleProtocol> Protocols { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The target URLs of the rule")]
        [ValidateNotNullOrEmpty]
        public List<string> TargetUrls { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The actions of the rule")]
        [ValidateNotNullOrEmpty]
        public List<PSSecureGatewayApplicationRuleAction> Actions { get; set; }
    }
}
