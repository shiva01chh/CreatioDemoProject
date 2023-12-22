namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CommunicationConstantsSchema

	/// <exclude/>
	public class CommunicationConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CommunicationConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CommunicationConstantsSchema(CommunicationConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e9a5adfa-2804-4de4-87ad-c536b6ee39e7");
			Name = "CommunicationConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,207,74,196,48,16,135,207,91,232,59,132,61,233,33,110,178,109,218,46,226,161,127,23,15,194,66,215,7,136,73,90,3,109,82,154,20,41,178,239,110,90,61,184,34,226,28,103,190,249,125,51,147,145,170,5,245,108,172,232,239,125,207,247,20,237,133,25,40,19,224,44,198,145,26,221,216,187,92,171,70,182,211,72,173,212,202,247,222,125,111,51,76,47,157,100,192,88,215,99,128,117,212,24,144,235,190,159,148,100,43,230,118,140,53,142,92,232,205,110,119,53,4,118,30,4,128,224,168,117,219,137,5,184,206,27,5,229,90,117,51,56,78,146,127,81,103,183,242,252,200,193,3,80,226,109,29,220,108,69,35,8,143,233,30,146,38,72,160,192,24,195,132,96,1,17,194,132,112,20,50,132,249,246,118,253,235,111,197,233,85,171,213,240,67,80,162,32,174,246,36,133,69,156,229,176,168,156,32,67,168,90,4,69,132,202,67,144,228,209,191,4,245,83,253,75,124,138,14,4,227,44,132,56,168,16,44,145,139,79,147,40,251,188,191,64,97,238,52,107,252,230,226,123,151,197,242,189,62,0,78,248,165,217,188,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9a5adfa-2804-4de4-87ad-c536b6ee39e7"));
		}

		#endregion

	}

	#endregion

}

