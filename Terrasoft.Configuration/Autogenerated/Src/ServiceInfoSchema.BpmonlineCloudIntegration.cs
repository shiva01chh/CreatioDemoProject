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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,193,110,194,48,12,64,207,32,241,15,86,185,108,151,246,62,6,23,152,166,29,152,208,186,219,180,67,40,78,23,169,77,144,237,78,98,104,255,62,55,45,12,16,23,122,73,236,248,217,47,169,55,53,242,214,20,8,239,72,100,56,88,73,231,193,91,87,54,100,196,5,159,206,159,242,101,216,96,197,163,225,126,52,28,52,236,124,9,249,142,5,235,244,173,241,226,106,76,115,36,103,42,247,19,137,201,104,168,117,99,194,82,3,152,87,134,249,1,180,226,219,21,248,226,109,136,199,89,150,193,35,55,117,109,104,55,235,227,5,90,231,93,219,2,108,32,40,170,208,108,128,59,240,128,100,39,204,199,194,136,81,89,33,83,200,167,38,182,205,186,114,133,130,58,242,124,226,96,31,167,30,173,86,20,182,72,226,80,213,86,145,234,206,47,181,98,226,25,133,65,133,184,93,229,11,193,235,163,65,176,113,223,251,165,71,250,212,176,83,92,98,189,70,186,123,109,169,41,36,61,209,134,201,125,171,125,240,102,161,248,182,255,231,176,135,18,101,210,78,158,192,239,45,138,186,17,109,198,151,154,138,34,66,65,104,167,201,210,184,74,107,250,121,121,79,36,217,236,166,203,244,212,217,77,174,119,134,227,230,202,181,198,232,55,221,207,137,113,151,61,79,198,156,126,127,87,91,169,90,180,2,0,0 };
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

