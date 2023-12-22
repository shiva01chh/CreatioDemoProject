namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ConfigurationServiceResponseSchema

	/// <exclude/>
	public class ConfigurationServiceResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ConfigurationServiceResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ConfigurationServiceResponseSchema(ConfigurationServiceResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bbd217b6-97c9-4dc1-83e9-27fef9bede8a");
			Name = "ConfigurationServiceResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbd880ce-b4f0-465b-921f-c6a2e08aa5ce");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,83,77,79,195,48,12,61,103,18,255,33,210,46,67,66,253,1,160,93,128,9,113,24,66,116,55,196,33,100,110,137,232,146,202,113,198,199,180,255,142,179,118,75,91,6,226,68,15,85,28,191,247,226,103,39,86,173,192,215,74,131,92,0,162,242,174,160,236,202,217,194,148,1,21,25,103,79,70,155,147,145,8,222,216,82,230,31,158,96,117,49,136,179,135,96,201,172,32,203,1,141,170,204,231,142,151,80,73,248,46,152,8,90,27,13,115,183,132,42,187,86,164,248,52,66,165,41,17,102,136,14,111,109,225,228,180,87,21,66,143,189,39,102,7,60,75,176,200,99,87,245,137,55,234,240,92,25,45,117,165,188,151,61,115,173,220,3,183,192,89,15,242,92,94,42,127,8,153,186,217,41,138,49,66,201,240,72,246,132,65,147,67,127,46,239,119,186,13,162,61,227,55,245,201,169,140,173,20,34,15,90,3,151,50,149,172,5,209,183,216,254,93,101,246,174,161,142,9,9,123,193,180,53,149,61,189,49,216,101,83,122,223,199,61,186,26,144,12,28,119,145,244,210,170,57,201,3,181,171,142,139,66,85,190,57,86,136,125,153,57,41,10,49,153,3,245,247,38,107,85,5,56,109,241,221,89,51,244,16,246,80,219,31,44,9,209,53,53,7,122,113,75,118,84,183,142,154,116,235,105,109,144,130,170,228,160,192,239,229,29,233,47,2,5,180,210,194,219,144,190,233,184,184,226,75,25,7,144,221,0,45,62,106,158,119,118,199,175,235,172,129,204,185,87,170,108,0,237,186,205,176,148,126,93,96,124,131,49,153,194,198,251,126,158,71,221,164,246,245,154,247,187,135,68,250,247,242,7,23,114,55,83,254,117,191,47,206,91,233,255,146,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bbd217b6-97c9-4dc1-83e9-27fef9bede8a"));
		}

		#endregion

	}

	#endregion

}

