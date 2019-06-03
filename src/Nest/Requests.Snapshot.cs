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
using System.Runtime.Serialization;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.SnapshotApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	[InterfaceDataContract]
	public partial interface ISnapshotRequest : IRequest<SnapshotRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}

		[IgnoreDataMember]
		Name Snapshot
		{
			get;
		}
	}

	///<summary>Request for Snapshot <pre>http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</pre></summary>
	public partial class SnapshotRequest : PlainRequestBase<SnapshotRequestParameters>, ISnapshotRequest
	{
		protected ISnapshotRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotSnapshot;
		///<summary>/_snapshot/{repository}/{snapshot}</summary>
		///<param name = "repository">this parameter is required</param>
		///<param name = "snapshot">this parameter is required</param>
		public SnapshotRequest(Name repository, Name snapshot): base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected SnapshotRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name ISnapshotRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		[IgnoreDataMember]
		Name ISnapshotRequest.Snapshot => Self.RouteValues.Get<Name>("snapshot");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Should this request wait until the operation has completed before returning</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	[InterfaceDataContract]
	public partial interface ICreateRepositoryRequest : IRequest<CreateRepositoryRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}
	}

	///<summary>Request for CreateRepository <pre>http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</pre></summary>
	public partial class CreateRepositoryRequest : PlainRequestBase<CreateRepositoryRequestParameters>, ICreateRepositoryRequest
	{
		protected ICreateRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotCreateRepository;
		///<summary>/_snapshot/{repository}</summary>
		///<param name = "repository">this parameter is required</param>
		public CreateRepositoryRequest(Name repository): base(r => r.Required("repository", repository))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected CreateRepositoryRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name ICreateRepositoryRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Whether to verify the repository after creation</summary>
		public bool? Verify
		{
			get => Q<bool? >("verify");
			set => Q("verify", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IDeleteSnapshotRequest : IRequest<DeleteSnapshotRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}

		[IgnoreDataMember]
		Name Snapshot
		{
			get;
		}
	}

	///<summary>Request for Delete <pre>http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</pre></summary>
	public partial class DeleteSnapshotRequest : PlainRequestBase<DeleteSnapshotRequestParameters>, IDeleteSnapshotRequest
	{
		protected IDeleteSnapshotRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotDelete;
		///<summary>/_snapshot/{repository}/{snapshot}</summary>
		///<param name = "repository">this parameter is required</param>
		///<param name = "snapshot">this parameter is required</param>
		public DeleteSnapshotRequest(Name repository, Name snapshot): base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteSnapshotRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IDeleteSnapshotRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		[IgnoreDataMember]
		Name IDeleteSnapshotRequest.Snapshot => Self.RouteValues.Get<Name>("snapshot");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IDeleteRepositoryRequest : IRequest<DeleteRepositoryRequestParameters>
	{
		[IgnoreDataMember]
		Names RepositoryName
		{
			get;
		}
	}

	///<summary>Request for DeleteRepository <pre>http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</pre></summary>
	public partial class DeleteRepositoryRequest : PlainRequestBase<DeleteRepositoryRequestParameters>, IDeleteRepositoryRequest
	{
		protected IDeleteRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotDeleteRepository;
		///<summary>/_snapshot/{repository}</summary>
		///<param name = "repository">this parameter is required</param>
		public DeleteRepositoryRequest(Names repository): base(r => r.Required("repository", repository))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteRepositoryRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Names IDeleteRepositoryRequest.RepositoryName => Self.RouteValues.Get<Names>("repository");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetSnapshotRequest : IRequest<GetSnapshotRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}

		[IgnoreDataMember]
		Names Snapshot
		{
			get;
		}
	}

	///<summary>Request for Get <pre>http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</pre></summary>
	public partial class GetSnapshotRequest : PlainRequestBase<GetSnapshotRequestParameters>, IGetSnapshotRequest
	{
		protected IGetSnapshotRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotGet;
		///<summary>/_snapshot/{repository}/{snapshot}</summary>
		///<param name = "repository">this parameter is required</param>
		///<param name = "snapshot">this parameter is required</param>
		public GetSnapshotRequest(Name repository, Names snapshot): base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected GetSnapshotRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IGetSnapshotRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		[IgnoreDataMember]
		Names IGetSnapshotRequest.Snapshot => Self.RouteValues.Get<Names>("snapshot");
		// Request parameters
		///<summary>Whether to ignore unavailable snapshots, defaults to false which means a SnapshotMissingException is thrown</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Whether to show verbose snapshot info or only show the basic info found in the repository index blob</summary>
		public bool? Verbose
		{
			get => Q<bool? >("verbose");
			set => Q("verbose", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetRepositoryRequest : IRequest<GetRepositoryRequestParameters>
	{
		[IgnoreDataMember]
		Names RepositoryName
		{
			get;
		}
	}

	///<summary>Request for GetRepository <pre>http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</pre></summary>
	public partial class GetRepositoryRequest : PlainRequestBase<GetRepositoryRequestParameters>, IGetRepositoryRequest
	{
		protected IGetRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotGetRepository;
		///<summary>/_snapshot</summary>
		public GetRepositoryRequest(): base()
		{
		}

		///<summary>/_snapshot/{repository}</summary>
		///<param name = "repository">Optional, accepts null</param>
		public GetRepositoryRequest(Names repository): base(r => r.Optional("repository", repository))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Names IGetRepositoryRequest.RepositoryName => Self.RouteValues.Get<Names>("repository");
		// Request parameters
		///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}

		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IRestoreRequest : IRequest<RestoreRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}

		[IgnoreDataMember]
		Name Snapshot
		{
			get;
		}
	}

	///<summary>Request for Restore <pre>http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</pre></summary>
	public partial class RestoreRequest : PlainRequestBase<RestoreRequestParameters>, IRestoreRequest
	{
		protected IRestoreRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotRestore;
		///<summary>/_snapshot/{repository}/{snapshot}/_restore</summary>
		///<param name = "repository">this parameter is required</param>
		///<param name = "snapshot">this parameter is required</param>
		public RestoreRequest(Name repository, Name snapshot): base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected RestoreRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IRestoreRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		[IgnoreDataMember]
		Name IRestoreRequest.Snapshot => Self.RouteValues.Get<Name>("snapshot");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Should this request wait until the operation has completed before returning</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	[InterfaceDataContract]
	public partial interface ISnapshotStatusRequest : IRequest<SnapshotStatusRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}

		[IgnoreDataMember]
		Names Snapshot
		{
			get;
		}
	}

	///<summary>Request for Status <pre>http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</pre></summary>
	public partial class SnapshotStatusRequest : PlainRequestBase<SnapshotStatusRequestParameters>, ISnapshotStatusRequest
	{
		protected ISnapshotStatusRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotStatus;
		///<summary>/_snapshot/_status</summary>
		public SnapshotStatusRequest(): base()
		{
		}

		///<summary>/_snapshot/{repository}/_status</summary>
		///<param name = "repository">Optional, accepts null</param>
		public SnapshotStatusRequest(Name repository): base(r => r.Optional("repository", repository))
		{
		}

		///<summary>/_snapshot/{repository}/{snapshot}/_status</summary>
		///<param name = "repository">Optional, accepts null</param>
		///<param name = "snapshot">Optional, accepts null</param>
		public SnapshotStatusRequest(Name repository, Names snapshot): base(r => r.Optional("repository", repository).Optional("snapshot", snapshot))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name ISnapshotStatusRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		[IgnoreDataMember]
		Names ISnapshotStatusRequest.Snapshot => Self.RouteValues.Get<Names>("snapshot");
		// Request parameters
		///<summary>Whether to ignore unavailable snapshots, defaults to false which means a SnapshotMissingException is thrown</summary>
		public bool? IgnoreUnavailable
		{
			get => Q<bool? >("ignore_unavailable");
			set => Q("ignore_unavailable", value);
		}

		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IVerifyRepositoryRequest : IRequest<VerifyRepositoryRequestParameters>
	{
		[IgnoreDataMember]
		Name RepositoryName
		{
			get;
		}
	}

	///<summary>Request for VerifyRepository <pre>http://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html</pre></summary>
	public partial class VerifyRepositoryRequest : PlainRequestBase<VerifyRepositoryRequestParameters>, IVerifyRepositoryRequest
	{
		protected IVerifyRepositoryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotVerifyRepository;
		///<summary>/_snapshot/{repository}/_verify</summary>
		///<param name = "repository">this parameter is required</param>
		public VerifyRepositoryRequest(Name repository): base(r => r.Required("repository", repository))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected VerifyRepositoryRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IVerifyRepositoryRequest.RepositoryName => Self.RouteValues.Get<Name>("repository");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public Time MasterTimeout
		{
			get => Q<Time>("master_timeout");
			set => Q("master_timeout", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}
	}
}