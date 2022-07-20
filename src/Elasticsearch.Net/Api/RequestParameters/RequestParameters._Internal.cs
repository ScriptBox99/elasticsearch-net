// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Elastic.Transport;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification._InternalApi
{
	///<summary>Request options for DeleteDesiredNodes <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/delete-desired-nodes.html</para></summary>
	public class DeleteDesiredNodesRequestParameters : RequestParameters<DeleteDesiredNodesRequestParameters>
	{
	}

	///<summary>Request options for GetDesiredNodes <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/get-desired-nodes.html</para></summary>
	public class GetDesiredNodesRequestParameters : RequestParameters<GetDesiredNodesRequestParameters>
	{
	}

	///<summary>Request options for Health</summary>
	public class HealthRequestParameters : RequestParameters<HealthRequestParameters>
	{
		///<summary>Include details on returned indicators</summary>
		public bool? Explain
		{
			get => Q<bool? >("explain");
			set => Q("explain", value);
		}

		///<summary>Explicit operation timeout</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}
	}

	///<summary>Request options for UpdateDesiredNodes <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/update-desired-nodes.html</para></summary>
	public class UpdateDesiredNodesRequestParameters : RequestParameters<UpdateDesiredNodesRequestParameters>
	{
	}
}