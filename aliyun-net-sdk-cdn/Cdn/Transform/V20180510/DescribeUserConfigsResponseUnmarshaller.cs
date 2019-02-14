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
using Aliyun.Acs.Cdn.Model.V20180510;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeUserConfigsResponseUnmarshaller
    {
        public static DescribeUserConfigsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeUserConfigsResponse describeUserConfigsResponse = new DescribeUserConfigsResponse();

			describeUserConfigsResponse.HttpResponse = context.HttpResponse;
			describeUserConfigsResponse.RequestId = context.StringValue("DescribeUserConfigs.RequestId");

			DescribeUserConfigsResponse.DescribeUserConfigs_Configs configs = new DescribeUserConfigsResponse.DescribeUserConfigs_Configs();

			DescribeUserConfigsResponse.DescribeUserConfigs_Configs.DescribeUserConfigs_OssLogConfig ossLogConfig = new DescribeUserConfigsResponse.DescribeUserConfigs_Configs.DescribeUserConfigs_OssLogConfig();
			ossLogConfig.Enable = context.StringValue("DescribeUserConfigs.Configs.OssLogConfig.Enable");
			ossLogConfig.Bucket = context.StringValue("DescribeUserConfigs.Configs.OssLogConfig.Bucket");
			ossLogConfig.Prefix = context.StringValue("DescribeUserConfigs.Configs.OssLogConfig.Prefix");
			configs.OssLogConfig = ossLogConfig;

			DescribeUserConfigsResponse.DescribeUserConfigs_Configs.DescribeUserConfigs_GreenManagerConfig greenManagerConfig = new DescribeUserConfigsResponse.DescribeUserConfigs_Configs.DescribeUserConfigs_GreenManagerConfig();
			greenManagerConfig.Quota = context.StringValue("DescribeUserConfigs.Configs.GreenManagerConfig.Quota");
			greenManagerConfig.Ratio = context.StringValue("DescribeUserConfigs.Configs.GreenManagerConfig.Ratio");
			configs.GreenManagerConfig = greenManagerConfig;

			DescribeUserConfigsResponse.DescribeUserConfigs_Configs.DescribeUserConfigs_WafConfig wafConfig = new DescribeUserConfigsResponse.DescribeUserConfigs_Configs.DescribeUserConfigs_WafConfig();
			wafConfig.Enable = context.StringValue("DescribeUserConfigs.Configs.WafConfig.Enable");
			configs.WafConfig = wafConfig;
			describeUserConfigsResponse.Configs = configs;
        
			return describeUserConfigsResponse;
        }
    }
}