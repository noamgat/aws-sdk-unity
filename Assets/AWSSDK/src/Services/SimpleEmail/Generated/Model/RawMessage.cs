//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

/*
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents the raw data of the message.
    /// </summary>
    public partial class RawMessage
    {
        private MemoryStream _data;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RawMessage() { }

        /// <summary>
        /// Instantiates RawMessage with the parameterized properties
        /// </summary>
        /// <param name="data">The raw data of the message. The client must ensure that the message format complies with Internet email standards regarding email header fields, MIME types, MIME encoding, and base64 encoding (if necessary).  The To:, CC:, and BCC: headers in the raw message can contain a group list.  If you are using <code>SendRawEmail</code> with sending authorization, you can include X-headers in the raw message to specify the "Source," "From," and "Return-Path" addresses. For more information, see the documentation for <code>SendRawEmail</code>.  <important>Do not include these X-headers in the DKIM signature, because they are removed by Amazon SES before sending the email.</important> For more information, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-email-raw.html">Amazon SES Developer Guide</a>. </param>
        public RawMessage(MemoryStream data)
        {
            _data = data;
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The raw data of the message. The client must ensure that the message format complies
        /// with Internet email standards regarding email header fields, MIME types, MIME encoding,
        /// and base64 encoding (if necessary). 
        /// </para>
        ///  
        /// <para>
        /// The To:, CC:, and BCC: headers in the raw message can contain a group list. 
        /// </para>
        ///  
        /// <para>
        /// If you are using <code>SendRawEmail</code> with sending authorization, you can include
        /// X-headers in the raw message to specify the "Source," "From," and "Return-Path" addresses.
        /// For more information, see the documentation for <code>SendRawEmail</code>. 
        /// </para>
        ///  <important>Do not include these X-headers in the DKIM signature, because they are
        /// removed by Amazon SES before sending the email.</important> 
        /// <para>
        /// For more information, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-email-raw.html">Amazon
        /// SES Developer Guide</a>. 
        /// </para>
        /// </summary>
        public MemoryStream Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

    }
}