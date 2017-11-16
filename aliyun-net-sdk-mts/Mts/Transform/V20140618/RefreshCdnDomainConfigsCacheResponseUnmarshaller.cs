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
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class RefreshCdnDomainConfigsCacheResponseUnmarshaller
    {
        public static RefreshCdnDomainConfigsCacheResponse Unmarshall(UnmarshallerContext context)
        {
			RefreshCdnDomainConfigsCacheResponse refreshCdnDomainConfigsCacheResponse = new RefreshCdnDomainConfigsCacheResponse();

			refreshCdnDomainConfigsCacheResponse.HttpResponse = context.HttpResponse;
			refreshCdnDomainConfigsCacheResponse.RequestId = context.StringValue("RefreshCdnDomainConfigsCache.RequestId");

			List<string> refreshCdnDomainConfigsCacheResponse_sucessDomains = new List<string>();
			for (int i = 0; i < context.Length("RefreshCdnDomainConfigsCache.SucessDomains.Length"); i++) {
				refreshCdnDomainConfigsCacheResponse_sucessDomains.Add(context.StringValue("RefreshCdnDomainConfigsCache.SucessDomains["+ i +"]"));
			}
			refreshCdnDomainConfigsCacheResponse.SucessDomains = refreshCdnDomainConfigsCacheResponse_sucessDomains;

			List<string> refreshCdnDomainConfigsCacheResponse_failedDomains = new List<string>();
			for (int i = 0; i < context.Length("RefreshCdnDomainConfigsCache.FailedDomains.Length"); i++) {
				refreshCdnDomainConfigsCacheResponse_failedDomains.Add(context.StringValue("RefreshCdnDomainConfigsCache.FailedDomains["+ i +"]"));
			}
			refreshCdnDomainConfigsCacheResponse.FailedDomains = refreshCdnDomainConfigsCacheResponse_failedDomains;
        
			return refreshCdnDomainConfigsCacheResponse;
        }
    }
}