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
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.IndexLifecycleManagementApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>Descriptor for DeleteLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-delete-lifecycle.html</para></summary>
	public partial class DeleteLifecycleDescriptor : RequestDescriptorBase<DeleteLifecycleDescriptor, DeleteLifecycleRequestParameters, IDeleteLifecycleRequest>, IDeleteLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementDeleteLifecycle;
		///<summary>/_ilm/policy/{policy_id}</summary>
		///<param name = "policyId">this parameter is required</param>
		public DeleteLifecycleDescriptor(Id policyId): base(r => r.Required("policy_id", policyId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteLifecycleDescriptor(): base()
		{
		}

		// values part of the url path
		Id IDeleteLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	///<summary>Descriptor for ExplainLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-explain-lifecycle.html</para></summary>
	public partial class ExplainLifecycleDescriptor : RequestDescriptorBase<ExplainLifecycleDescriptor, ExplainLifecycleRequestParameters, IExplainLifecycleRequest>, IExplainLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementExplainLifecycle;
		///<summary>/{index}/_ilm/explain</summary>
		///<param name = "index">this parameter is required</param>
		public ExplainLifecycleDescriptor(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ExplainLifecycleDescriptor(): base()
		{
		}

		// values part of the url path
		IndexName IExplainLifecycleRequest.Index => Self.RouteValues.Get<IndexName>("index");
		///<summary>The name of the index to explain</summary>
		public ExplainLifecycleDescriptor Index(IndexName index) => Assign(index, (a, v) => a.RouteValues.Required("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public ExplainLifecycleDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Required("index", (IndexName)v));
	// Request parameters
	}

	///<summary>Descriptor for GetLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-get-lifecycle.html</para></summary>
	public partial class GetLifecycleDescriptor : RequestDescriptorBase<GetLifecycleDescriptor, GetLifecycleRequestParameters, IGetLifecycleRequest>, IGetLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementGetLifecycle;
		///<summary>/_ilm/policy/{policy_id}</summary>
		///<param name = "policyId">Optional, accepts null</param>
		public GetLifecycleDescriptor(Id policyId): base(r => r.Optional("policy_id", policyId))
		{
		}

		///<summary>/_ilm/policy</summary>
		public GetLifecycleDescriptor(): base()
		{
		}

		// values part of the url path
		Id IGetLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
		///<summary>The name of the index lifecycle policy</summary>
		public GetLifecycleDescriptor PolicyId(Id policyId) => Assign(policyId, (a, v) => a.RouteValues.Optional("policy_id", v));
	// Request parameters
	}

	///<summary>Descriptor for GetStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-get-status.html</para></summary>
	public partial class GetIlmStatusDescriptor : RequestDescriptorBase<GetIlmStatusDescriptor, GetIlmStatusRequestParameters, IGetIlmStatusRequest>, IGetIlmStatusRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementGetStatus;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for MoveToStep <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-move-to-step.html</para></summary>
	public partial class MoveToStepDescriptor : RequestDescriptorBase<MoveToStepDescriptor, MoveToStepRequestParameters, IMoveToStepRequest>, IMoveToStepRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementMoveToStep;
		///<summary>/_ilm/move/{index}</summary>
		///<param name = "index">this parameter is required</param>
		public MoveToStepDescriptor(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected MoveToStepDescriptor(): base()
		{
		}

		// values part of the url path
		IndexName IMoveToStepRequest.Index => Self.RouteValues.Get<IndexName>("index");
		///<summary>The name of the index whose lifecycle step is to change</summary>
		public MoveToStepDescriptor Index(IndexName index) => Assign(index, (a, v) => a.RouteValues.Required("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public MoveToStepDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Required("index", (IndexName)v));
	// Request parameters
	}

	///<summary>Descriptor for PutLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-put-lifecycle.html</para></summary>
	public partial class PutLifecycleDescriptor : RequestDescriptorBase<PutLifecycleDescriptor, PutLifecycleRequestParameters, IPutLifecycleRequest>, IPutLifecycleRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementPutLifecycle;
		///<summary>/_ilm/policy/{policy_id}</summary>
		///<param name = "policyId">this parameter is required</param>
		public PutLifecycleDescriptor(Id policyId): base(r => r.Required("policy_id", policyId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutLifecycleDescriptor(): base()
		{
		}

		// values part of the url path
		Id IPutLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	///<summary>Descriptor for RemovePolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-remove-policy.html</para></summary>
	public partial class RemovePolicyDescriptor : RequestDescriptorBase<RemovePolicyDescriptor, RemovePolicyRequestParameters, IRemovePolicyRequest>, IRemovePolicyRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementRemovePolicy;
		///<summary>/{index}/_ilm/remove</summary>
		///<param name = "index">this parameter is required</param>
		public RemovePolicyDescriptor(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected RemovePolicyDescriptor(): base()
		{
		}

		// values part of the url path
		IndexName IRemovePolicyRequest.Index => Self.RouteValues.Get<IndexName>("index");
		///<summary>The name of the index to remove policy on</summary>
		public RemovePolicyDescriptor Index(IndexName index) => Assign(index, (a, v) => a.RouteValues.Required("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public RemovePolicyDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Required("index", (IndexName)v));
	// Request parameters
	}

	///<summary>Descriptor for Retry <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-retry-policy.html</para></summary>
	public partial class RetryIlmDescriptor : RequestDescriptorBase<RetryIlmDescriptor, RetryIlmRequestParameters, IRetryIlmRequest>, IRetryIlmRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementRetry;
		///<summary>/{index}/_ilm/retry</summary>
		///<param name = "index">this parameter is required</param>
		public RetryIlmDescriptor(IndexName index): base(r => r.Required("index", index))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected RetryIlmDescriptor(): base()
		{
		}

		// values part of the url path
		IndexName IRetryIlmRequest.Index => Self.RouteValues.Get<IndexName>("index");
		///<summary>The name of the indices (comma-separated) whose failed lifecycle step is to be retry</summary>
		public RetryIlmDescriptor Index(IndexName index) => Assign(index, (a, v) => a.RouteValues.Required("index", v));
		///<summary>a shortcut into calling Index(typeof(TOther))</summary>
		public RetryIlmDescriptor Index<TOther>()
			where TOther : class => Assign(typeof(TOther), (a, v) => a.RouteValues.Required("index", (IndexName)v));
	// Request parameters
	}

	///<summary>Descriptor for Start <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-start.html</para></summary>
	public partial class StartIlmDescriptor : RequestDescriptorBase<StartIlmDescriptor, StartIlmRequestParameters, IStartIlmRequest>, IStartIlmRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementStart;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for Stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ilm-stop.html</para></summary>
	public partial class StopIlmDescriptor : RequestDescriptorBase<StopIlmDescriptor, StopIlmRequestParameters, IStopIlmRequest>, IStopIlmRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementStop;
	// values part of the url path
	// Request parameters
	}
}