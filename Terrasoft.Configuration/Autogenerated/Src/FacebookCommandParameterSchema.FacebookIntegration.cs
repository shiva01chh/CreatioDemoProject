namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookCommandParameterSchema

	/// <exclude/>
	public class FacebookCommandParameterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookCommandParameterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookCommandParameterSchema(FacebookCommandParameterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("55eedac6-1832-49bb-ada6-3ce9df23cd0c");
			Name = "FacebookCommandParameter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,142,61,10,131,64,16,133,107,5,239,176,144,126,15,96,186,8,169,82,132,232,5,198,117,148,33,238,172,217,159,34,145,220,61,163,130,141,100,186,247,248,248,222,48,88,12,19,24,84,13,122,15,193,245,81,87,142,123,26,146,135,72,142,117,237,12,193,88,228,115,145,103,41,16,15,234,42,120,235,220,243,188,55,245,59,68,180,250,70,252,58,148,143,196,145,44,234,26,189,120,232,179,90,133,18,238,228,113,144,160,170,17,66,40,119,111,229,172,5,238,238,224,229,185,136,126,101,167,212,142,100,148,89,208,191,164,42,213,5,2,30,5,217,188,74,190,219,44,114,183,45,47,81,58,185,31,194,196,203,243,8,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55eedac6-1832-49bb-ada6-3ce9df23cd0c"));
		}

		#endregion

	}

	#endregion

}

