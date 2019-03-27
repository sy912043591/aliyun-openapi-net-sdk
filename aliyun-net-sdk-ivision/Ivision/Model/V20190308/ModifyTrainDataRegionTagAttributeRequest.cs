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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.ivision.Transform;
using Aliyun.Acs.ivision.Transform.V20190308;

namespace Aliyun.Acs.ivision.Model.V20190308
{
    public class ModifyTrainDataRegionTagAttributeRequest : RpcAcsRequest<ModifyTrainDataRegionTagAttributeResponse>
    {
        public ModifyTrainDataRegionTagAttributeRequest()
            : base("ivision", "2019-03-08", "ModifyTrainDataRegionTagAttribute", "ivision", "openAPI")
        {
        }

		private string action;

		private string projectId;

		private string showLog;

		private string tagItems;

		private long? ownerId;

		private string dataId;

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value);
			}
		}

		public string ShowLog
		{
			get
			{
				return showLog;
			}
			set	
			{
				showLog = value;
				DictionaryUtil.Add(QueryParameters, "ShowLog", value);
			}
		}

		public string TagItems
		{
			get
			{
				return tagItems;
			}
			set	
			{
				tagItems = value;
				DictionaryUtil.Add(QueryParameters, "TagItems", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string DataId
		{
			get
			{
				return dataId;
			}
			set	
			{
				dataId = value;
				DictionaryUtil.Add(QueryParameters, "DataId", value);
			}
		}

        public override ModifyTrainDataRegionTagAttributeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyTrainDataRegionTagAttributeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
