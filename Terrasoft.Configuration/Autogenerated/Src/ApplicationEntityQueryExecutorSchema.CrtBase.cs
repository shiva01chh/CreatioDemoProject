namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApplicationEntityQueryExecutorSchema

	/// <exclude/>
	public class ApplicationEntityQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApplicationEntityQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApplicationEntityQueryExecutorSchema(ApplicationEntityQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("afadda41-08ff-4cac-864b-dc9f22b7ea37");
			Name = "ApplicationEntityQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,82,77,107,2,49,20,60,43,248,31,30,246,178,130,236,222,213,10,106,109,241,96,233,231,169,244,16,119,223,174,1,77,150,124,148,138,244,191,247,37,89,113,87,212,94,42,44,152,151,153,201,100,38,32,216,22,117,201,82,132,55,84,138,105,153,155,120,38,69,206,11,171,152,225,82,116,218,251,78,187,101,53,23,69,3,162,112,120,97,30,79,202,114,195,83,207,214,241,100,165,141,98,169,95,92,100,204,133,225,134,227,101,192,61,41,72,21,16,132,185,81,88,144,32,204,54,76,235,1,212,14,244,74,187,103,139,106,55,255,198,212,18,203,51,146,36,129,145,182,219,45,83,187,113,181,246,40,192,10,6,57,125,232,233,160,211,53,110,153,6,153,3,59,106,199,7,157,164,38,244,113,135,57,179,27,51,229,34,35,227,145,217,149,40,243,104,113,198,72,175,15,143,20,55,220,66,247,186,227,110,239,147,148,75,187,34,12,164,238,142,127,92,17,6,48,101,26,107,160,87,127,131,6,104,20,136,97,199,89,223,251,100,142,97,82,67,70,89,23,52,101,250,228,79,15,136,202,201,117,15,209,187,70,69,26,2,125,217,96,27,203,62,44,136,190,100,130,21,168,92,168,213,223,158,211,111,13,96,69,246,163,83,74,13,6,238,21,182,126,42,199,40,178,96,186,121,131,37,154,181,204,156,121,37,13,137,96,22,246,79,203,15,3,46,214,168,184,201,100,10,201,113,90,239,182,85,30,116,64,126,209,131,228,25,2,69,228,222,231,11,106,42,189,158,104,168,118,124,166,219,238,240,255,109,132,51,171,116,154,205,194,3,154,198,118,212,115,190,154,245,196,117,74,133,27,158,77,55,100,222,28,250,89,253,247,11,253,106,186,232,72,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("afadda41-08ff-4cac-864b-dc9f22b7ea37"));
		}

		#endregion

	}

	#endregion

}

