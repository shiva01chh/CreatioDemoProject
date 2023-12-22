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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,142,65,10,131,48,16,69,215,10,222,33,208,125,14,96,119,21,186,234,162,212,94,96,140,163,12,53,19,155,73,22,173,244,238,141,10,82,144,206,238,127,30,239,15,131,69,25,193,160,186,163,247,32,174,11,186,114,220,81,31,61,4,114,172,107,103,8,134,34,159,138,60,139,66,220,171,115,194,27,231,30,199,173,169,95,18,208,234,11,241,115,87,222,34,7,178,168,107,244,201,67,239,197,154,168,196,29,60,246,41,168,106,0,145,114,243,86,206,90,224,246,10,62,61,23,208,47,236,24,155,129,140,50,51,250,151,84,165,58,129,224,94,144,77,139,228,179,206,34,183,235,242,28,83,247,123,95,146,64,109,224,17,1,0,0 };
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

