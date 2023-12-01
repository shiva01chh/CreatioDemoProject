namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicationConstsSchema

	/// <exclude/>
	public class DeduplicationConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicationConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicationConstsSchema(DeduplicationConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2f63d953-bd1e-490d-81f5-9a26e360c7c0");
			Name = "DeduplicationConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,189,78,195,48,20,133,103,42,245,29,172,178,192,224,230,167,105,147,80,64,162,38,66,12,136,161,188,192,77,124,19,44,53,78,100,59,66,21,226,221,177,221,22,10,136,1,188,88,247,231,156,243,13,87,66,139,186,135,10,201,19,42,5,186,171,205,148,117,178,22,205,160,192,136,78,146,215,241,232,100,208,66,54,100,189,213,6,219,229,120,100,59,167,10,27,55,101,27,208,250,130,220,34,31,202,141,168,188,196,234,181,209,126,45,8,2,114,169,135,182,5,181,189,222,215,118,108,64,72,77,42,183,7,210,104,82,171,174,117,229,81,44,23,149,251,65,9,212,211,131,83,112,100,213,251,64,98,29,140,253,42,199,225,49,250,175,24,142,223,110,255,32,241,141,207,125,36,93,143,251,104,74,214,8,170,122,158,126,232,142,115,191,5,43,4,222,201,205,150,220,13,130,239,133,143,7,171,123,78,174,136,196,23,63,60,155,20,81,58,75,67,198,40,91,20,25,77,162,36,166,55,197,42,167,217,42,46,162,249,138,133,25,203,38,231,75,23,242,103,228,7,84,13,254,131,216,235,126,3,78,114,30,46,242,56,166,243,16,144,38,60,231,180,228,188,164,81,178,224,179,24,234,168,76,83,15,108,83,222,118,119,129,146,239,78,195,149,190,103,223,59,80,32,70,63,102,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f63d953-bd1e-490d-81f5-9a26e360c7c0"));
		}

		#endregion

	}

	#endregion

}

