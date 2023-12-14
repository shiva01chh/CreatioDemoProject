namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceInfoSchema

	/// <exclude/>
	public class ServiceInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceInfoSchema(ServiceInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8e8ff62d-d15e-4cbb-bf69-9d73591e0c11");
			Name = "ServiceInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,177,110,194,48,16,64,103,144,248,135,83,88,218,37,217,75,97,9,85,213,129,10,53,221,170,14,38,156,83,75,137,141,238,156,74,20,245,223,123,118,66,10,136,133,44,246,157,239,221,61,59,86,53,200,59,85,34,188,35,145,98,167,125,154,59,171,77,213,146,242,198,217,52,127,42,86,110,139,53,79,198,135,201,120,212,178,177,21,20,123,246,216,164,111,173,245,166,193,180,64,50,170,54,63,145,152,77,198,82,55,37,172,36,128,188,86,204,15,32,21,223,166,196,23,171,93,60,206,178,12,30,185,109,26,69,251,69,31,47,81,27,107,66,11,208,142,160,172,93,187,5,238,192,35,146,157,48,31,75,229,149,200,122,82,165,255,148,196,174,221,212,166,20,80,70,158,79,28,29,226,212,193,106,77,110,135,228,13,138,218,58,82,221,249,165,86,76,60,163,103,16,33,14,171,255,66,176,242,104,224,116,220,247,126,233,64,159,26,118,138,43,108,54,72,119,175,129,154,67,210,19,33,76,238,131,246,209,155,61,197,183,253,63,135,3,84,232,103,97,242,12,126,111,81,148,141,151,102,124,169,41,40,34,148,132,122,158,172,148,169,165,166,159,87,244,68,146,45,110,186,76,79,157,221,228,122,103,24,54,87,174,53,69,187,237,126,78,140,187,236,121,50,230,194,247,7,159,107,130,199,181,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e8ff62d-d15e-4cbb-bf69-9d73591e0c11"));
		}

		#endregion

	}

	#endregion

}

