﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Linq.Expressions;
using Nest.Resolvers;
using Nest.Domain;

namespace Nest
{
	[DescriptorFor("IndicesDeleteMapping")]
	public partial class DeleteMappingDescriptor : 
		IndexTypePathDescriptor<DeleteMappingDescriptor, DeleteMappingQueryString>
		, IPathInfo<DeleteMappingQueryString>
	{
		ElasticsearchPathInfo<DeleteMappingQueryString> IPathInfo<DeleteMappingQueryString>.ToPathInfo(IConnectionSettingsValues settings)
		{
			var pathInfo = base.ToPathInfo<DeleteMappingQueryString>(settings, this._QueryString);
			pathInfo.HttpMethod = PathInfoHttpMethod.DELETE;

			return pathInfo;
		}
	}
}
