/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Slb.Model.V20140515;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class CreateRulesResponseUnmarshaller
    {
        public static CreateRulesResponse Unmarshall(UnmarshallerContext context)
        {
			CreateRulesResponse createRulesResponse = new CreateRulesResponse();

			createRulesResponse.HttpResponse = context.HttpResponse;
			createRulesResponse.RequestId = context.StringValue("CreateRules.RequestId");

			List<CreateRulesResponse.CreateRules_Rule> createRulesResponse_rules = new List<CreateRulesResponse.CreateRules_Rule>();
			for (int i = 0; i < context.Length("CreateRules.Rules.Length"); i++) {
				CreateRulesResponse.CreateRules_Rule rule = new CreateRulesResponse.CreateRules_Rule();
				rule.RuleId = context.StringValue("CreateRules.Rules["+ i +"].RuleId");
				rule.RuleName = context.StringValue("CreateRules.Rules["+ i +"].RuleName");

				createRulesResponse_rules.Add(rule);
			}
			createRulesResponse.Rules = createRulesResponse_rules;
        
			return createRulesResponse;
        }
    }
}