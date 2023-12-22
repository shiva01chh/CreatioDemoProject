namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IReportGeneratorSchema

	/// <exclude/>
	public class IReportGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IReportGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IReportGeneratorSchema(IReportGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f7efd48-adaa-42e5-b285-f3efa252f7e7");
			Name = "IReportGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,65,106,195,48,16,60,39,144,63,44,238,165,133,98,221,19,215,151,22,74,14,133,144,54,15,80,229,181,35,136,37,179,146,2,33,244,239,149,37,219,216,174,235,139,209,104,102,119,118,86,138,215,104,26,46,16,190,144,136,27,93,218,244,85,171,82,86,142,184,149,90,109,214,247,205,122,229,140,84,213,127,148,244,136,141,38,251,137,116,149,2,119,139,116,106,113,127,243,64,88,121,9,236,149,69,42,125,223,45,236,163,252,29,21,250,122,154,2,143,49,6,153,113,117,205,233,150,119,231,3,233,171,44,208,0,5,1,84,81,209,182,42,157,18,173,21,126,145,246,150,246,122,54,42,208,184,239,139,20,32,251,190,11,109,87,247,208,122,240,248,129,246,172,11,179,133,67,208,198,203,185,177,0,116,69,6,107,233,192,100,115,106,214,112,226,53,40,159,251,75,226,12,146,143,82,97,48,159,228,39,127,6,49,0,105,198,2,123,89,44,198,59,72,242,33,157,9,14,165,166,89,94,154,254,214,37,180,142,148,201,143,241,15,141,151,112,194,162,159,39,99,61,163,149,196,228,222,184,229,195,228,143,167,201,40,48,157,236,25,102,97,79,222,207,212,241,211,174,219,2,170,34,46,34,156,127,226,243,153,128,1,27,127,191,162,114,248,39,206,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f7efd48-adaa-42e5-b285-f3efa252f7e7"));
		}

		#endregion

	}

	#endregion

}

