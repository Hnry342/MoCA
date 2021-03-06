/**
* Copyright 2018, 2019 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using Newtonsoft.Json;

namespace IBM.Watson.Discovery.V1.Model
{
    /// <summary>
    /// Object that defines a box folder to crawl with this configuration.
    /// </summary>
    public class SourceOptionsFolder
    {
        /// <summary>
        /// The Box user ID of the user who owns the folder to crawl.
        /// </summary>
        [JsonProperty("owner_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerUserId { get; set; }
        /// <summary>
        /// The Box folder ID of the folder to crawl.
        /// </summary>
        [JsonProperty("folder_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FolderId { get; set; }
        /// <summary>
        /// The maximum number of documents to crawl for this folder. By default, all documents in the folder are
        /// crawled.
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Limit { get; set; }
    }
}
